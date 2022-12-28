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
       

        public int Id { get; set; }
        public string Name { get; set; }
        
        public string Status { get; set; }

        public TaskItem(string status,string name, int id)
        {
            Status = status;
            Name = name;
            Id = id;

        }
               
    }
}
