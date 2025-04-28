// Description: File contains the methods needed for the Tasks section of the application

namespace Task_Tracker.Models
{
    // Class for creating Tasks
    public class TaskItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    
        // Constructor to create a Class
        public TaskItem(string title)
        {
            Title = title;
            IsCompleted = false;
        }
        
        // Description: Method that overrides the ToString method to display a summary
        // Parameters: N\A
        // Returns: String
        public override string ToString()
        {
            return IsCompleted ? $"[Done] {Title}" : Title;
        }
    }
}
