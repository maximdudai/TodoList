using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoproject
{
    internal class Todo
    {
        public string Task { get; set; }
        public bool IsComplete { get; set; }

        public int Priority { get; set; }

        public DateTime DueDate { get; set; }


        public Todo(string task, int priority, DateTime dueDate)
        {
            Task = task;
            Priority = priority;
            DueDate = dueDate;
        }

        public bool isTaskCompleted()
        {
            return this.IsComplete;
        }
        public void markAsComplete()
        {
            this.IsComplete = !this.IsComplete;
        }
    }
}
