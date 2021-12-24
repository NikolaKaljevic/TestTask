namespace Task_Tracker.Models;
    public enum Status
    {
        To_Do,
        In_Progress,
        Done
    }
    public enum Task_Priority
    {
        Low,
        High,
        Major
    }
    public class Task
    {
        private static int next_task = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Status _status;

        public Task_Priority _priority;


        // Task constructors
        public Task() { }
        public Task(string name, string description, Status status, Task_Priority priority) 
        {
            Id = ++next_task;
            Name = name;
            Description = description;
            _status = status;
            _priority = priority;
        }
    }