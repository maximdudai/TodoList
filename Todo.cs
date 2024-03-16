using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todoproject
{
    internal class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool IsComplete { get; set; }


        public Todo(int id, string task, bool isComplete)
        {
            Id = id;
            Task = task;
            IsComplete = isComplete;
        }

        public bool isTaskComplete()
        {
            return this.IsComplete;
        }

        public override string ToString()
        {
            return $"(#{this.Id}) {this.Task}";
        }
      
    }
}
