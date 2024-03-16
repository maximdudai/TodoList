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

        private List<String> TodoList;

        public Form1()
        {
            InitializeComponent();

            TodoList = new List<String>();
        }

        private void onPriorityChanged(object sender, EventArgs e)
        {
            // prevent user to select more than one priority level

            var priorityLevel = priorityBox.SelectedIndex;
            for(var i = 0; i < priorityBox.Items.Count; i++)
            {
               if(i != priorityLevel)
               {
                   priorityBox.SetItemChecked(i, false);    
               }
            }   
        }

        private void handleAddNewTask_Click(object sender, EventArgs e)
        {

        }

        private void handleMarkAsDone_Click(object sender, EventArgs e)
        {

        }

        private void handleDeleteTask_Click(object sender, EventArgs e)
        {

        }
    }
}
