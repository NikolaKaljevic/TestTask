
namespace Task_Tracker.Models;

    public enum Current_status
    {
        Not_started,
        Active,
        Completed
    }
    public enum Priority
    {
        Low,
        High,
        Major
    }

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime Start_date { get; set; }

        //public DateTime? Completion_date = null;
        //public Current_status currentStatus { get; set; }
        //public Priority priority { get; set; }

        public static List<Task> Task_list { get; set; } = new List<Task>(){ new Task ()};

        //Project class constructor
        //public Project(int _id, string _name, DateTime _start_date, DateTime? _completion_date, Current_status _currentstatus, Priority _priority)
        //{
        //    Id = _id;
        //    Name = _name;
        //    Start_date = _start_date;
        //    Completion_date = _completion_date;
        //    currentStatus = _currentstatus;
        //    priority = _priority;
        //}
}

