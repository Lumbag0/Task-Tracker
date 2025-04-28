// Description: Interface for working with the Task Storages

using Task_Tracker.Models;
namespace Task_Tracker.Storage
{
    internal interface ITaskStorage
    {
        // Method that saves tasks to a JSON file
        void SaveTasks(List<TaskItem> tasks);
        
        // Method that loads a task from a JSON file
        List<TaskItem> LoadTasks();
    }
}
