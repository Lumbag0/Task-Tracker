using System.Windows.Forms.Design;
using Task_Tracker.Models;
using Task_Tracker.Storage;

namespace Task_Tracker
{
    public partial class Main_Form : Form
    {
        private ITaskStorage Task_Storage;
        private List<TaskItem> tasks = new List<TaskItem>();
        private string lastSavedFilepath = null;

        // Description: Helper method that refreshes the tasks in the list
        // Parameters: N\A
        // Returns: N\A
        private void Refresh_Task_List()
        {
            list_tasks.DataSource = null;
            list_tasks.DataSource = tasks;
        }

        // Description: Method that saves the tasks into a JSON file
        private void save_tasks()
        {
            // If the user already saved the file before, dont prompt again
            if (!string.IsNullOrEmpty(lastSavedFilepath))
            {
                Task_Storage = new Task_Storage(lastSavedFilepath);
                Task_Storage.SaveTasks(tasks);
                MessageBox.Show("Tasks saved successfully!");
            }
            else
            {
                // Ask the user to save if they have never saved
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = Application.StartupPath;
                    saveFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                    saveFileDialog.Title = "Save Tasks as";
                    saveFileDialog.FileName = "new_tasks.json";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        lastSavedFilepath = saveFileDialog.FileName;

                        Task_Storage = new Task_Storage(lastSavedFilepath);
                        Task_Storage.SaveTasks(tasks);
                        MessageBox.Show("Tasks saved successfully!");
                    }
                }
            }
        }

        // Description: Method for the button "Add Task" that handles adding a task to the list
        private void Btn_Add_Task_Click(object sender, EventArgs e)
        {
            string taskTitle = Txt_New_Task.Text.Trim();

            // As long as the task title is not empty, add it to the list
            if (!string.IsNullOrEmpty(taskTitle))
            {
                TaskItem newTask = new TaskItem(taskTitle);
                tasks.Add(newTask);
                Refresh_Task_List();
                Txt_New_Task.Clear();
            }
        }

        // Description: Method for the "Completed" button that marks the task for completion
        private void Btn_Mark_Complete_Click(object sender, EventArgs e)
        {
            if (list_tasks.SelectedItem is TaskItem selectedTask)
            {
                // Set the task's value to completed
                //selectedTask.IsCompleted = true;
                //Refresh_Task_List();
                if (selectedTask.IsCompleted == false)
                {
                    selectedTask.IsCompleted = true;
                }
                else
                {
                    selectedTask.IsCompleted = false;
                }
                Refresh_Task_List();
            }
            else
            {
                MessageBox.Show("Please select a task to mark as complete...");
            }
        }

        // Description: Method for the "Delete" button which deletes the task from the list
        private void Btn_Delete_Task_Click(object sender, EventArgs e)
        {
            if (list_tasks.SelectedItem is TaskItem selectedTask)
            {
                // Delete the selected task from the list
                tasks.Remove(selectedTask);
                Refresh_Task_List();
            }
            else
            {
                MessageBox.Show("Please select a task to delete...");
            }
        }

        // Description: Method for the "Save" button which saves the tasks to a JSON file
        private void Btn_Save_Tasks_Click(object sender, EventArgs e)
        {
            save_tasks();
        }

        // Description: Method for the "Load" method which load tasks from a JSON file
        private void Btn_Load_Tasks_Click(object sender, EventArgs e)
        {
            // Open up a dialog box in current directory in order to select a file to pull from
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            { 
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
                openFileDialog.Title = "Select a tasks.json file";

                // If everything worked correctly, add the tasks to the list
                if(openFileDialog.ShowDialog() == DialogResult.OK) 
                {
                    Task_Storage = new Task_Storage(openFileDialog.FileName);
                    tasks = Task_Storage.LoadTasks();
                    Refresh_Task_List();
                }
            }
        }

        public Main_Form()
        {
            InitializeComponent();
            Task_Storage = new Task_Storage("tasks_new.json");
            Task_Storage.LoadTasks();
        }

        // Description: Actions to perform when closing
        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the tasks to the tasks_new file
            save_tasks();
        }
    }
}
