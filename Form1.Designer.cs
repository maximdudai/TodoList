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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startTaskTime = new System.Windows.Forms.DateTimePicker();
            this.endTaskTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.CheckedListBox();
            this.listOfTodos = new System.Windows.Forms.ListView();
            this.taskInput = new System.Windows.Forms.TextBox();
            this.handleAddNewTask = new System.Windows.Forms.Button();
            this.handleDeleteTask = new System.Windows.Forms.Button();
            this.handleMarkAsDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(542, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "list of todo\'s";
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
            // endTaskTime
            // 
            this.endTaskTime.Location = new System.Drawing.Point(173, 128);
            this.endTaskTime.Name = "endTaskTime";
            this.endTaskTime.Size = new System.Drawing.Size(200, 20);
            this.endTaskTime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "END DATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 199);
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
            this.priorityBox.Location = new System.Drawing.Point(173, 178);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(200, 49);
            this.priorityBox.TabIndex = 8;
            this.priorityBox.SelectedIndexChanged += new System.EventHandler(this.onPriorityChanged);
            // 
            // listOfTodos
            // 
            this.listOfTodos.HideSelection = false;
            this.listOfTodos.Location = new System.Drawing.Point(475, 72);
            this.listOfTodos.Name = "listOfTodos";
            this.listOfTodos.Size = new System.Drawing.Size(374, 389);
            this.listOfTodos.TabIndex = 9;
            this.listOfTodos.UseCompatibleStateImageBehavior = false;
            // 
            // taskInput
            // 
            this.taskInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskInput.Location = new System.Drawing.Point(67, 244);
            this.taskInput.Multiline = true;
            this.taskInput.Name = "taskInput";
            this.taskInput.Size = new System.Drawing.Size(306, 217);
            this.taskInput.TabIndex = 10;
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
            this.handleDeleteTask.Location = new System.Drawing.Point(674, 471);
            this.handleDeleteTask.Name = "handleDeleteTask";
            this.handleDeleteTask.Size = new System.Drawing.Size(175, 43);
            this.handleDeleteTask.TabIndex = 12;
            this.handleDeleteTask.Text = "DELETE TASK";
            this.handleDeleteTask.UseVisualStyleBackColor = true;
            this.handleDeleteTask.Click += new System.EventHandler(this.handleDeleteTask_Click);
            // 
            // handleMarkAsDone
            // 
            this.handleMarkAsDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.handleMarkAsDone.Location = new System.Drawing.Point(475, 471);
            this.handleMarkAsDone.Name = "handleMarkAsDone";
            this.handleMarkAsDone.Size = new System.Drawing.Size(175, 43);
            this.handleMarkAsDone.TabIndex = 13;
            this.handleMarkAsDone.Text = "MARK AS DONE";
            this.handleMarkAsDone.UseVisualStyleBackColor = true;
            this.handleMarkAsDone.Click += new System.EventHandler(this.handleMarkAsDone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 526);
            this.Controls.Add(this.handleMarkAsDone);
            this.Controls.Add(this.handleDeleteTask);
            this.Controls.Add(this.handleAddNewTask);
            this.Controls.Add(this.taskInput);
            this.Controls.Add(this.listOfTodos);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endTaskTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startTaskTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startTaskTime;
        private System.Windows.Forms.DateTimePicker endTaskTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox priorityBox;
        private System.Windows.Forms.ListView listOfTodos;
        private System.Windows.Forms.TextBox taskInput;
        private System.Windows.Forms.Button handleAddNewTask;
        private System.Windows.Forms.Button handleDeleteTask;
        private System.Windows.Forms.Button handleMarkAsDone;
    }
}

