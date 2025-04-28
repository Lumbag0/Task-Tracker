namespace Task_Tracker
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Txt_New_Task = new TextBox();
            Btn_Add_Task = new Button();
            list_tasks = new ListBox();
            Btn_Mark_Complete = new Button();
            Btn_Delete_Task = new Button();
            Btn_Save_Tasks = new Button();
            Btn_Load_Tasks = new Button();
            SuspendLayout();
            // 
            // Txt_New_Task
            // 
            Txt_New_Task.ForeColor = SystemColors.GrayText;
            Txt_New_Task.Location = new Point(12, 12);
            Txt_New_Task.Name = "Txt_New_Task";
            Txt_New_Task.Size = new Size(100, 23);
            Txt_New_Task.TabIndex = 0;
            Txt_New_Task.Text = "New Task";
            // 
            // Btn_Add_Task
            // 
            Btn_Add_Task.Location = new Point(123, 12);
            Btn_Add_Task.Name = "Btn_Add_Task";
            Btn_Add_Task.Size = new Size(75, 23);
            Btn_Add_Task.TabIndex = 1;
            Btn_Add_Task.Text = "Add Task";
            Btn_Add_Task.UseVisualStyleBackColor = true;
            Btn_Add_Task.Click += Btn_Add_Task_Click;
            // 
            // list_tasks
            // 
            list_tasks.FormattingEnabled = true;
            list_tasks.Location = new Point(12, 48);
            list_tasks.Name = "list_tasks";
            list_tasks.Size = new Size(186, 109);
            list_tasks.TabIndex = 2;
            // 
            // Btn_Mark_Complete
            // 
            Btn_Mark_Complete.Location = new Point(204, 48);
            Btn_Mark_Complete.Name = "Btn_Mark_Complete";
            Btn_Mark_Complete.Size = new Size(75, 23);
            Btn_Mark_Complete.TabIndex = 3;
            Btn_Mark_Complete.Text = "Completed";
            Btn_Mark_Complete.UseVisualStyleBackColor = true;
            Btn_Mark_Complete.Click += Btn_Mark_Complete_Click;
            // 
            // Btn_Delete_Task
            // 
            Btn_Delete_Task.Location = new Point(204, 77);
            Btn_Delete_Task.Name = "Btn_Delete_Task";
            Btn_Delete_Task.Size = new Size(75, 23);
            Btn_Delete_Task.TabIndex = 4;
            Btn_Delete_Task.Text = "Delete";
            Btn_Delete_Task.UseVisualStyleBackColor = true;
            Btn_Delete_Task.Click += Btn_Delete_Task_Click;
            // 
            // Btn_Save_Tasks
            // 
            Btn_Save_Tasks.Location = new Point(204, 106);
            Btn_Save_Tasks.Name = "Btn_Save_Tasks";
            Btn_Save_Tasks.Size = new Size(75, 23);
            Btn_Save_Tasks.TabIndex = 5;
            Btn_Save_Tasks.Text = "Save";
            Btn_Save_Tasks.UseVisualStyleBackColor = true;
            Btn_Save_Tasks.Click += Btn_Save_Tasks_Click;
            // 
            // Btn_Load_Tasks
            // 
            Btn_Load_Tasks.Location = new Point(204, 135);
            Btn_Load_Tasks.Name = "Btn_Load_Tasks";
            Btn_Load_Tasks.Size = new Size(75, 23);
            Btn_Load_Tasks.TabIndex = 6;
            Btn_Load_Tasks.Text = "Load Tasks";
            Btn_Load_Tasks.UseVisualStyleBackColor = true;
            Btn_Load_Tasks.Click += Btn_Load_Tasks_Click;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 259);
            Controls.Add(Btn_Load_Tasks);
            Controls.Add(Btn_Save_Tasks);
            Controls.Add(Btn_Delete_Task);
            Controls.Add(Btn_Mark_Complete);
            Controls.Add(list_tasks);
            Controls.Add(Btn_Add_Task);
            Controls.Add(Txt_New_Task);
            Name = "Main_Form";
            Text = "Task Tracker";
            FormClosing += Main_Form_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_New_Task;
        private Button Btn_Add_Task;
        private ListBox list_tasks;
        private Button Btn_Mark_Complete;
        private Button Btn_Delete_Task;
        private Button Btn_Save_Tasks;
        private Button Btn_Load_Tasks;
    }
}
