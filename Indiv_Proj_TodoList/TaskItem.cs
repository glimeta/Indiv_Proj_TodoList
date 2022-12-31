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
        private string _name;
        private string _status;
        private int _id;
       

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }

        public string Status { get => _status; set => _status = value; }

        public string TaskPriority { get; set; } 

        public TaskItem()
        {

        }
               
        public TaskItem(string taskPriority, string status, string name, int id)
        {
            this.Id = id;
            this.Status = status;
            this.Name = name;
            this.TaskPriority = taskPriority;
        }
                

        public virtual void DisplayList()
        {
            //Console.CLear();
            //Console.WriteLine("\t Task List");
            Console.WriteLine($"Id: {this.Id}\t|\tDescription: {this.Name}\t|\tStatus: {this.Status}\tTaskPriority: {this.TaskPriority}");
        }



    }
}
