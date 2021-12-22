using Microsoft.AspNetCore.Mvc;
using Task = Task_Tracker.Models.Task;
using TaskService = Task_Tracker.Services.TaskService;
namespace Task_Tracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        // GET all Tasks
        [HttpGet]
        public ActionResult<List<Task>> GetAll()
        {
            return TaskService.GetAll();
        }


        //// GET by Id action
        //[HttpGet("{id}")]
        //public ActionResult<Task> Get(int id)
        //{ 
        //    var task = TaskService.Get(id);

        //    if (task == null)
        //        return NotFound();

        //    return task;
        //}

        // POST action
        [HttpPost]
        public IActionResult Create(Task task)
        {
            TaskService.Add(task);
            return CreatedAtAction(nameof(Create), new { id = task.Id }, task);
        }

        //// PUT action
        //[HttpPut("{id}")]
        //public IActionResult Update(int id, Task task)
        //{
        //    if (id != task.Id)
        //    return BadRequest();

        //    var currentTask = TaskService.Get(id);
        //    if(currentTask is null)
        //        return NotFound();

        //    TaskService.Update(task);           

        //    return NoContent();
        //}

        //// DELETE action
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    var task = TaskService.Get(id);

        //    if (task is null)
        //    return NotFound();

        //    TaskService.Delete(id);

        //    return NoContent();
        //}
    }
}
