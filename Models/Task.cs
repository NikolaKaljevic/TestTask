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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Status _status;

        public Task_Priority _priority;
        
        // Task constructor
        public Task(int id, string name, string description, Status status, Task_Priority priority) 
        {
            Id = ++id;
            Name = name;
            Description = description;
            _status = status;
            _priority = priority;
        }
    }