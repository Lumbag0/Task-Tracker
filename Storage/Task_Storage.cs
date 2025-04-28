using Task_Tracker.Models;
using Newtonsoft.Json;

namespace Task_Tracker.Storage
{
    internal class Task_Storage : ITaskStorage
    {
        private readonly string filepath;

        // Constructor that sets the filepath
        public Task_Storage(string filepath)
        {
            this.filepath = filepath;
        }

        // Description: Method that saves the current set of tasks into a JSON file
        // Parameters: List of Tasks
        // Returns: N\A
        public void SaveTasks(List<TaskItem> tasks)
        {
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(filepath, json);
        }

        // Description: Method that loads a set of tasks from a JSON file
        // Parameters: N\A
        // Returns: List of Tasks
        public List<TaskItem> LoadTasks()
        {
            // Check that the JSON file exists
            if (File.Exists(filepath))
            {
                // Read through the JSON file and convert them to be used in the application
                string json = File.ReadAllText(filepath);
                var tasks = JsonConvert.DeserializeObject<List<TaskItem>>(json);
                return tasks ?? new List<TaskItem>();
            }
            else
            {
                return new List<TaskItem>();
            }
        }
    }
}