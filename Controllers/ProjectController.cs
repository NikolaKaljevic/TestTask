using Microsoft.AspNetCore.Mvc;
using Task_Tracker.Models;
using Task_Tracker.Services;

namespace Task_Tracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        //GET
        [HttpGet]
        public ActionResult<List<Project>> GetAll() =>
        ProjectService.GetAll();

        // POST action
        [HttpPost]
        public IActionResult Create(Project project)
        {
            ProjectService.Add(project);
            return CreatedAtAction(nameof(Create), new { id = project.Id }, project);
        }
    }
}
