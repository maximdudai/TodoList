using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todoproject
{
    public partial class Form1 : Form
    {
        // check if end date is not earlier than start date
        // possibility using enter key to add new task

        private List<Todo> Todos;

        public Form1()
        {
            InitializeComponent();

            Todos = new List<Todo>();
        }
     

        private void handleAddNewTask_Click(object sender, EventArgs e)
        {
            string task = getTask();

            int priorityLevel = getTaskPriority();
            DateTime time = DateTime.Now;

            if(verifyIfTaskIsEmpty(task))
            {
                MessageBox.Show("Task cannot be empty", "Error", MessageBoxButtons.OK);
                return;
            }
            Todo todo = new Todo(task, priorityLevel, time);


            Todos.Add(todo);

            // reset task input
            clearTaskInput();

            createNewTask(todo);
        }

        private void handleMarkAsDone_Click(object sender, EventArgs e)
        {
            int selectedRow = ListOfTodos.CurrentCell.RowIndex;

            Console.WriteLine(selectedRow);

            if (selectedRow < 0)
            {
                MessageBox.Show("Please select a task to mark as done", "Error", MessageBoxButtons.OK);
                return;
            }

            Todos[selectedRow].markAsComplete();
            bool isornot = Todos[selectedRow].isTaskCompleted();
            Console.WriteLine(isornot);

            refreshTodoList(Todos[selectedRow].isTaskCompleted());
        }

        private void handleDeleteTask_Click(object sender, EventArgs e)
        {

        }

        private bool verifyIfTaskIsEmpty(string task)
        {
            if (task.Length == 0)
            {
                return true;
            }
            return false;
        }
        private string getTask()
        {
            string taskDescription = taskInput.Text;
            if (verifyIfTaskIsEmpty(taskDescription))
            {
                MessageBox.Show("Task cannot be empty");
                return "";
            }
            return taskDescription;
        }

        private void clearTaskInput()
        {
            taskInput.Text = "";
            priorityBox.SelectedIndex = 0;
        }

        private void createNewTask(object data)
        {
            string task = ((Todo)data).Task;

            int priorityLevel = ((Todo)data).Priority;
            string priority = getColorByPriority(priorityLevel);

            bool isCompleted = ((Todo)data).isTaskCompleted();

            DateTime time = ((Todo)data).DueDate;
        
            this.ListOfTodos.Rows.Add(isCompleted, time, priority, task);
        }

        private void refreshTodoList(bool isCompleted)
        {
            int selectedRow = this.ListOfTodos.CurrentCell.RowIndex;

            this.ListOfTodos.Rows[selectedRow].Cells[0].Value = isCompleted;
            this.ListOfTodos.Rows[selectedRow].DefaultCellStyle.BackColor = isCompleted ? Color.LightGreen : Color.White;

            this.ListOfTodos.Refresh();
        }

        private void handleCreateTask(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                handleAddNewTask_Click(sender, e);
                clearTaskInput();
            }
        }
        private int getTaskPriority()
        {
            return priorityBox.SelectedIndex;
        }
        private string getColorByPriority(int priority)
        {
            switch (priority)
            {
                case 0: // low
                    return "LOW";
                case 1: // medium
                    return "MEDIUM";
                case 2: // high
                    return "HIGH";
                default:
                    return "LOW";
            }
        }

        private void onPriorityChanged(object sender, EventArgs e)
        {
            // prevent user to select more than one priority level

            var priorityLevel = priorityBox.SelectedIndex;

            for (var i = 0; i < priorityBox.Items.Count; i++)
            {
                if (i != priorityLevel)
                {
                    priorityBox.SetItemChecked(i, false);
                }
            }
        }
    }
}
