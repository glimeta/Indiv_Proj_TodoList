using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_Proj_TodoList
{
    public class TaskList : List<TaskItem>
    {
        public TaskList()
        {

        }
            
        public void Add(string status, string name, int id)
        {
            int numberOfTasks = this.Count();
            int number = numberOfTasks++;

            this.Add(new TaskItem(status, name, id));

        }
            
           // List<TaskItem> lstTasks = new List<TaskItem>();
    }
}
