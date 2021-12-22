using Task_Tracker.Models;
using Task_Tracker.Services;

namespace Task_Tracker.Services;

    public static class ProjectService
    {
        public static List<Project> Project_list = new List<Project>() { new Project()};

        //GET
        public static List<Project> GetAll()
        {
            return Project_list;
        }
        
        //POST
        public static void Add(Project project)
        {
            Project_list.Add( project );
        }

        
    }

