using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Indiv_Proj_TodoList
{
    public class TaskItem
    {
        public string name;
        public int id;
        public string status;

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public string Status { get; set; }

        public TaskItem() { }

        public TaskItem(int Id, string Name, string Status)
        {
            Id = id;
            Name = name;
            Status = status;
            IsCompleted = false;
        }
        
    }
}
