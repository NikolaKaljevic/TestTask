using Task_Tracker.Models;
using Task = Task_Tracker.Models.Task;
using Task_Tracker.Services;

namespace Task_Tracker.Services
{
    public class TaskService
    {
        public static List<Task> Tasks_list = Project.Task_list;

        //GET
        public static List<Task> GetAll()
        {
            return Tasks_list;
        }
        
        //POST
        public static void Add(Task task)
        {
            Tasks_list.Add(task);

        }

        //Delete Task
        //public static void Delete(int id)
        //{
        //    var task = Get(id);
        //    if (task is null)
        //        return;

        //    Tasks.Remove(task);
        //}

        //Update Task
        //public void Update(Task task)
        //{
        //    var index = Tasks.FindIndex(p => p.Id == task.Id);
        //    if (index == -1)
        //        return;

        //    Tasks[index] = task;
        //}

    }
}