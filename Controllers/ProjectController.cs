using Microsoft.AspNetCore.Mvc;
using Task_Tracker.Models;
using Task_Tracker.Models.DataAccess;

namespace Task_Tracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        // Dependency injection
        private readonly DataContext _context;
        public ProjectController(DataContext context)
        {
            _context = context;
        }

        //GET all projects
        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetAll()
        {
            return Ok(await _context.Projects.ToListAsync());
        }

        // GET project by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> Get(int id)
        {
            var project = await _context.Projects.FindAsync(id);

            if (project == null)
                return NotFound("Project not found.");

            return Ok(project);
        }

        // POST    (create project)
        [HttpPost]
        public async Task<ActionResult<List<Project>>> Create(Project project)
        {
            _context.Projects.Add(project);
            await _context.SaveChangesAsync();
            return Ok(await _context.Projects.ToListAsync());
        }

        //PUT    (update project)
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Project>>> Update(Project request)
        {
            var dbProject = await _context.Projects.FindAsync(request.Id);
            if (dbProject == null)
                return BadRequest("Project not found.");

            dbProject.Name = request.Name;
            dbProject.Start_date = request.Start_date;
            dbProject.Completion_date = request.Completion_date;
            dbProject.currentStatus = request.currentStatus;
            dbProject.priority = request.priority;

            await _context.SaveChangesAsync();
            return Ok(await _context.Projects.ToListAsync());
        }

        //DELETE action
       [HttpDelete("{id}")]
        public async Task<ActionResult<List<Project>>> Delete(int id)
        {
            var dbProject = await _context.Projects.FindAsync(id);

            if (dbProject == null)
                return NotFound("Project not found.");

            _context.Projects.Remove(dbProject);
            await _context.SaveChangesAsync();

            return Ok(await _context.Projects.ToListAsync());
        }
    }
}
