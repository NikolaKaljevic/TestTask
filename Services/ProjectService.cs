using Task_Tracker.Models;
using Task_Tracker.Services;

namespace Task_Tracker.Services;

    public static class ProjectService
    {
        public static List<Project> Project_list = new List<Project>() { new Project(1, "Release", DateTime.Now, null, Current_status.Not_started, Priority.High),
                                                                         new Project(2, "Release_2", DateTime.Today, null, Current_status.Active, Priority.High)};

        public static Project? Get(int id) => Project_list.FirstOrDefault(p => p.Id == id);

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

        //DELETE
        public static void Delete(int id)
        {
            var project = Get(id);
            if (project is null)
                return;

            Project_list.Remove(project);
        }
        
        //UPDATE
        public static void Update(Project project)
        {
            var index = Project_list.FindIndex(p => p.Id == project.Id);
            if (index == -1)
                return;

            Project_list[index] = project;
        }

}

