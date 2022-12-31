// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information

using Indiv_Proj_TodoList;
using System.ComponentModel.Design;
using System.Data;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Runtime.CompilerServices;

namespace Indiv_Proj_TodoList
{
    public class Program
    {
        public static List<TaskItem> LstTasks { get; private set; }

        [STAThread]
        public static void Main()

        {
         
             void NumberTask(List<TaskItem> List)
                    {
                        int i = 1;
                        foreach (var task in List)
                        {
                            task.Id = i;
                            i++;
                        }

                    }
            Console.WriteLine("Welcome to ToDo List App");
            Console.WriteLine("-------------------------");

            menu:
                       
            Console.WriteLine("Pick an Option:");
            Console.WriteLine("Press (1) to Create task");
            Console.WriteLine("Press (2) to Update task (Name,Status,Priority ID)");
            Console.WriteLine("Press (3) to Delete task");
            Console.WriteLine("Press (4) to Quit");

            Console.WriteLine("");

            int process = Convert.ToInt32(Console.ReadLine());


            switch (process)
            {

                case 1:

                    //foreach (var it in LstTasks)
                    //{
                    //    Console.Write("\t*\t");
                    //    it.DisplayList();
                    //}

                    Methods.Input(LstTasks, 0);
                    goto menu;


                //case 2:
                //    //Console.WriteLine("Current task name =" + task.Name + "Enter the updated name");
                //    string updatedName = Console.ReadLine();
                //    //Console.WriteLine("Current priority Id =" + task.Id + "Enter the updated priority Id");
                //    int updatedId = Convert.ToInt32(Console.ReadLine());
                //    Console.WriteLine("Current status =" + task.Status + "Enter the updated status");
                //    string updatedStatus = Console.ReadLine();

                //    //tsk1.name = updatedName;
                //    //tsk1.id = updatedId;
                //    //tsk1.status = updatedStatus;

                //    //TaskItem task = new TaskItem(updatedStatus, updatedName, supdatedId);
                //    //lstTasks.Add(tsk);

                //    List<TaskItem> sortedItems = lstTasks = TaskItem.OrderBy(tsk => tsk.Id).ToList();

                //    Console.WriteLine("Done, task is updated");
                //    goto menu;


                case 3:
                //task.Name = null;
                //task.Id = 0;
                //task.Status = null;
                //Console.WriteLine("Done, task is deleted");
                //goto menu;


                case 4:

                    break;


                default:
                    Console.WriteLine("Wrong Input!!");
                    goto menu;

            }
         Console.ReadKey();
      }
   }
}


