using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_Proj_TodoList
{
    public class Methods
    {
        int value;

        public List<TaskItem> TodoList = new List<TaskItem>();
        public List<TaskItem> LstTasks = new List<TaskItem>();


        public static void Input(List<TaskItem> LstTasks, int numb_Of_Tasks)

        {
            bool flag = false;
            if (numb_Of_Tasks == 0)
            {
                numb_Of_Tasks = LstTasks.Count() + 1;
                flag = true;
            }

            Console.WriteLine("Enter task name");
            string dataName = Console.ReadLine();
            while (dataName.Trim() == "")
            {
                Console.WriteLine("Task name cannot be empty. Please enter name again");
                dataName = Console.ReadLine();
            }

            Console.WriteLine("Task priority: y = yes, n = no");
            string dataPriority;
            dataPriority = Console.ReadLine();
            if (dataPriority == "y")
            {
                dataPriority = "*";
            }
            else
            {
                dataPriority = "";
            }

            Console.WriteLine("Task priority Status, complete or incomplete.");
            string dataStatus = Console.ReadLine();

            if (dataStatus == "") dataStatus = "incomplete";

            while (dataStatus.Trim() == "")
            {
                Console.WriteLine("Please enter complete or incomplete. Blank means incomplete");
                dataStatus = Console.ReadLine();
                if (dataStatus == "") dataStatus = "incomplete";
            }


            var Task = new TaskItem(dataPriority, dataStatus, dataName, numb_Of_Tasks);

            if (flag)
            {
                LstTasks.Add(Task);
            }


            Console.WriteLine(" Priority          Task Name              Status                ID    ");
            Console.WriteLine("__________       ______________       ___________         ____________  ");
            Console.WriteLine("");


            foreach (TaskItem c in LstTasks)
            {
                Console.WriteLine(Task.TaskPriority.PadRight(20) + Task.Name.PadRight(20) + Task.Status.PadRight(20) + Task.Id);
            }


            Console.WriteLine("");
            Console.WriteLine("Done, task is saved");
            Console.WriteLine("");

            Console.WriteLine("");


        }
    }
}
