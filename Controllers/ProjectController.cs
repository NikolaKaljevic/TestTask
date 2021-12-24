using Microsoft.AspNetCore.Mvc;
using Task_Tracker.Models;
using Task_Tracker.Models.DataAccess;
using Task_Tracker.Services;

namespace Task_Tracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {

        //GET
        [HttpGet]
        public ActionResult<List<Project>> GetAll()
        {
            return ProjectService.GetAll();
        }

        // GET project by Id
        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
            var project = ProjectService.Get(id);

            if (project == null)
                return NotFound();

            return project;
        }

        // POST
        [HttpPost]
        public IActionResult Create(Project project)
        {
            ProjectService.Add(project);
            return CreatedAtAction(nameof(Create), new { id = project.Id }, project);
        }

        // PUT
        [HttpPut("{id}")]
        public IActionResult Update(int id, Project project)
        {
            if (id != project.Id)
                return BadRequest();

            var currentTask = ProjectService.Get(id);
            if (currentTask is null)
                return NotFound();

            ProjectService.Update(project);

            return NoContent();
        }

        // DELETE action
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var project = ProjectService.Get(id);

            if (project is null)
                return NotFound();

            ProjectService.Delete(id);

            return NoContent();
        }
    }
}
