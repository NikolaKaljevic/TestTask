using Microsoft.AspNetCore.Mvc;
using Task = Task_Tracker.Models.Task;
namespace Task_Tracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly DataContext _context;
        public TaskController(DataContext context)
        {
            _context = context;
        }

        // GET all Tasks
        [HttpGet]
        public async Task<ActionResult<List<Task>>> GetAll()
        {
            return Ok(await _context.Tasks.ToListAsync());
        }

        // GET Task by Id 
        [HttpGet("{id}")]
        public async Task<ActionResult<Task>> Get(int id)
        {
            var task = await _context.Tasks.FindAsync(id);

            if (task == null)
                return NotFound("Task not found.");

            return Ok(task);
        }

        // POST (create task)
        [HttpPost]
        public async Task<ActionResult<List<Task>>> Create(Task task)
        {
            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();
            return Ok(await _context.Tasks.ToListAsync());
        }

        // PUT (update task)
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Task>>> Update(Task request)
        {
            var dbTask = await _context.Tasks.FindAsync(request.Id);
            if (dbTask == null)
                return BadRequest("Task not found.");

            dbTask.Name = request.Name;
            dbTask.Description = request.Description;
            dbTask._status = request._status;
            dbTask._priority = request._priority;

            await _context.SaveChangesAsync();
            return Ok(await _context.Tasks.ToListAsync());
        }

        // DELETE task by id
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Task>>> Delete(int id)
        {
            var dbTask = await _context.Tasks.FindAsync(id);

            if (dbTask == null)
                return NotFound("Task not found.");

            _context.Tasks.Remove(dbTask);
            await _context.SaveChangesAsync();

            return Ok(await _context.Tasks.ToListAsync());
        }
    }
}
