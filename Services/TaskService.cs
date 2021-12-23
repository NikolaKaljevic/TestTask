using Task_Tracker.Models;
using Task = Task_Tracker.Models.Task;
using Task_Tracker.Services;

namespace Task_Tracker.Services
{
    public class TaskService
    {
        public static List<Task> Tasks_list = Project.Task_list;
        public static Task? Get(int id) => Tasks_list.FirstOrDefault(p => p.Id == id);

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

        //DELETE  Task
        public static void Delete(int id)
        {
            var task = Get(id);
            if (task is null)
                return;

            Tasks_list.Remove(task);
        }

        //PUT (UPDATE Task)
        public static void Update(Task task)
        {
            var index = Tasks_list.FindIndex(p => p.Id == task.Id);
            if (index == -1)
                return;

            Tasks_list[index] = task;
        }
    }
}