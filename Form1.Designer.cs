namespace todoproject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startTaskTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.CheckedListBox();
            this.taskInput = new System.Windows.Forms.TextBox();
            this.handleAddNewTask = new System.Windows.Forms.Button();
            this.handleDeleteTask = new System.Windows.Forms.Button();
            this.handleMarkAsDone = new System.Windows.Forms.Button();
            this.ListOfTodos = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorityLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfTodos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1049, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "list of todo\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "create new task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "START DATE";
            // 
            // startTaskTime
            // 
            this.startTaskTime.Location = new System.Drawing.Point(173, 72);
            this.startTaskTime.Name = "startTaskTime";
            this.startTaskTime.Size = new System.Drawing.Size(200, 20);
            this.startTaskTime.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PRIORITY";
            // 
            // priorityBox
            // 
            this.priorityBox.CheckOnClick = true;
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "LOW",
            "MEDIUM",
            "HIGH"});
            this.priorityBox.Location = new System.Drawing.Point(173, 137);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(200, 49);
            this.priorityBox.TabIndex = 8;
            this.priorityBox.SelectedIndexChanged += new System.EventHandler(this.onPriorityChanged);
            // 
            // taskInput
            // 
            this.taskInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskInput.Location = new System.Drawing.Point(67, 244);
            this.taskInput.Multiline = true;
            this.taskInput.Name = "taskInput";
            this.taskInput.Size = new System.Drawing.Size(306, 217);
            this.taskInput.TabIndex = 10;
            this.taskInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.handleCreateTask);
            // 
            // handleAddNewTask
            // 
            this.handleAddNewTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleAddNewTask.Location = new System.Drawing.Point(67, 471);
            this.handleAddNewTask.Name = "handleAddNewTask";
            this.handleAddNewTask.Size = new System.Drawing.Size(306, 43);
            this.handleAddNewTask.TabIndex = 11;
            this.handleAddNewTask.Text = "CREATE TASK";
            this.handleAddNewTask.UseVisualStyleBackColor = true;
            this.handleAddNewTask.Click += new System.EventHandler(this.handleAddNewTask_Click);
            // 
            // handleDeleteTask
            // 
            this.handleDeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleDeleteTask.Location = new System.Drawing.Point(1141, 467);
            this.handleDeleteTask.Name = "handleDeleteTask";
            this.handleDeleteTask.Size = new System.Drawing.Size(171, 43);
            this.handleDeleteTask.TabIndex = 12;
            this.handleDeleteTask.Text = "DELETE TASK";
            this.handleDeleteTask.UseVisualStyleBackColor = true;
            this.handleDeleteTask.Click += new System.EventHandler(this.handleDeleteTask_Click);
            // 
            // handleMarkAsDone
            // 
            this.handleMarkAsDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleMarkAsDone.Location = new System.Drawing.Point(919, 467);
            this.handleMarkAsDone.Name = "handleMarkAsDone";
            this.handleMarkAsDone.Size = new System.Drawing.Size(194, 43);
            this.handleMarkAsDone.TabIndex = 13;
            this.handleMarkAsDone.Text = "MARK AS DONE";
            this.handleMarkAsDone.UseVisualStyleBackColor = true;
            this.handleMarkAsDone.Click += new System.EventHandler(this.handleMarkAsDone_Click);
            // 
            // ListOfTodos
            // 
            this.ListOfTodos.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.ListOfTodos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.ListOfTodos.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListOfTodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ListOfTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.startDate,
            this.priorityLevel,
            this.task});
            this.ListOfTodos.Location = new System.Drawing.Point(394, 72);
            this.ListOfTodos.Name = "ListOfTodos";
            this.ListOfTodos.Size = new System.Drawing.Size(918, 389);
            this.ListOfTodos.TabIndex = 15;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Due Date";
            this.startDate.Name = "startDate";
            this.startDate.Width = 125;
            // 
            // priorityLevel
            // 
            this.priorityLevel.HeaderText = "Priority";
            this.priorityLevel.Name = "priorityLevel";
            this.priorityLevel.Width = 125;
            // 
            // task
            // 
            this.task.HeaderText = "Task";
            this.task.Name = "task";
            this.task.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 526);
            this.Controls.Add(this.ListOfTodos);
            this.Controls.Add(this.handleMarkAsDone);
            this.Controls.Add(this.handleDeleteTask);
            this.Controls.Add(this.handleAddNewTask);
            this.Controls.Add(this.taskInput);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startTaskTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Todo APP";
            ((System.ComponentModel.ISupportInitialize)(this.ListOfTodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startTaskTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox priorityBox;
        private System.Windows.Forms.TextBox taskInput;
        private System.Windows.Forms.Button handleAddNewTask;
        private System.Windows.Forms.Button handleDeleteTask;
        private System.Windows.Forms.Button handleMarkAsDone;
        private System.Windows.Forms.DataGridView ListOfTodos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn task;
    }
}

