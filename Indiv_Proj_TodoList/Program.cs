// See https://aka.ms/new-console-template for more information

using Indiv_Proj_TodoList;
using System.ComponentModel.Design;
using System.Data;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Welcome to ToDo List App");

menu:
Console.WriteLine("Pick an Option:");
Console.WriteLine("Press (1) to Create task");
Console.WriteLine("Press (2) to Read ToDo List");
Console.WriteLine("Press (3) to Update task (Name/Status");
Console.WriteLine("Press (4) to Delete task");
Console.WriteLine("Press (5) to Quit");

int process = Convert.ToInt32(Console.ReadLine());

TaskItem tsk = new TaskItem();   
List<TaskItem> lstTasks = new List<TaskItem>();

switch (process) {
     
        case 1:
            Console.WriteLine("Enter task name");
            string name = Console.ReadLine();
            Console.WriteLine("Task priority Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Task priority Status");
            string status = Console.ReadLine();

            tsk.name = name;
            tsk.id = id;
            tsk.status = status;
            Console.WriteLine("Done, task is saved");
            goto menu;

        case 2:
            Console.WriteLine("Task name =" + tsk.name);
            Console.WriteLine("Priority Id =" + tsk.id);
            Console.WriteLine("Status =" + tsk.status);
        

            TaskItem tsk = new TaskItem(id, name, status);
            lstTasks.Add(tsk);

            List<TaskItem> Todo = lstTasks.OrderBy(tsk => tsk.id).ToList();

            Public void DisplayList()
            {
                Console.WriteLine("Priority Id       Task Name       Status");
                Console.WriteLine("___________       _________       ______");

                foreach (TaskItem tsk in lstTasks)

                    Console.WriteLine("tsk.Id + tsk.Name + tsk,Status");
            }
            goto menu;

    case 3:
            Console.WriteLine("Current task name =" + tsk1.name + "Enter the updated name");
            string updatedName = Console.ReadLine();
            Console.WriteLine("Current priority Id =" + tsk1.id + "Enter the updated priority Id");
            int updatedId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current status =" + tsk1.status + "Enter the updated priority Id");
            string updatedStatus = Console.ReadLine();

            tsk1.name = updatedName;
            tsk1.id = updatedId;
            tsk1.status = updatedStatus;
            Console.WriteLine("Done, task is updated");
            goto menu;

        case 4:
            tsk1.name = null;
            tsk1.id = 0;
            tsk1.status = null;
            Console.WriteLine("Done, task is deleted");
            goto menu;


        case 5:

            break;



        default:
            Console.WriteLine("Wrong Input !!");
            goto menu;


    }

 Console.ReadKey();


