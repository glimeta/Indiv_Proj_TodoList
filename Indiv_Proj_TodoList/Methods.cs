using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indiv_Proj_TodoList
{
    public class Methods
    {
        private List<TaskItem> todoList = new List<TaskItem>();

        public void NumberTask(List<TaskItem> List)
        {
            int i = 1;
            foreach (var task in List)
            {
                task.ItemID = i;
                i++;
            }
        }

        public string CheckDelete(string input, List<TaskItem> list)
        {
            foreach (var task in list)
            {
                if (task.Description == input)
                {
                    list.Remove(task);
                    return "Task has been deleted";
                }
            }
            return "Can not find the name";
        }

        public void CheckUpdate(string input, List<TaskItem> list)
        {
            foreach (var task in list)
            {
                if (task.Description == input)
                {
                    Console.WriteLine("Input New Name of Task: ");
                    task.Description = Console.ReadLine();
                    while (task.Description.Trim() == "")
                    {
                        Console.WriteLine("New Name cannot be empty, please re-enter");
                        task.Description = Console.ReadLine();
                    }
                    Console.WriteLine("Task \"completed\" or \"incomplete\"(blank will be incomplete): ");
                    task.IsCompleted = Console.ReadLine();
                    if (task.IsCompleted == "") task.IsCompleted = "incomplete";
                    while (task.IsCompleted != "completed" && task.IsCompleted != "incomplete")
                    {
                        Console.WriteLine("Please define \"completed\" or \"incomplete\"(blank will be incomplete): ");
                        task.IsCompleted = Console.ReadLine();
                        if (task.IsCompleted == "") task.IsCompleted = "incomplete";
                    }
                    break;
                }
            }
            Console.WriteLine("Can not find the name");
        }

        public void Input(List<TaskItem> list, int ID)
        {
            bool flag = false;
            if (ID == 0)
            {
                ID = list.Count() + 1;
                flag = true;
            }
            Console.WriteLine("Input Name of Task. Start name with '*' if task is High Priority");
            string desc = Console.ReadLine();
            while (desc.Trim() == "")
            {
                Console.WriteLine("Name cannot be empty, please re-enter");
                desc = Console.ReadLine();
            }

            Console.WriteLine("Task \"completed\" or \"incomplete\"(blank will be incomplete): ");
            string iscomplete = Console.ReadLine();
            if (iscomplete == "") iscomplete = "incomplete";
            while (iscomplete != "completed" && iscomplete != "incomplete")
            {
                Console.WriteLine("Please define \"completed\" or \"incomplete\"(blank will be incomplete): ");
                iscomplete = Console.ReadLine();
                if (iscomplete == "") iscomplete = "Incomplete";
            }

            var Task = new TaskItem(iscomplete, desc, ID);
            if (flag)
            {
                list.Add(Task);
            }

        }

        public void MainProcess()
        {
            while (true)
            {
                string menuChoice = "";

                while (menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "4")              
                {
                    Console.WriteLine("");
                    Console.WriteLine("                 To Do List                  ");
                    Console.WriteLine("");
                    Console.WriteLine($"  STATUS             NAME                 ID         ");
                    Console.WriteLine($"__________       ______________       ___________    ");
                    Console.WriteLine($"");


                    foreach (var it in todoList)
                    {
                        
                        it.DisplayList();
                    }

                  
                    Console.WriteLine("");
                    Console.WriteLine("\t ===============================");
                    Console.WriteLine("\t|\t1.Add new item\t\t|");
                    Console.WriteLine("\t|\t2.Delete item\t\t|");
                    Console.WriteLine("\t|\t3.Update item\t\t|");
                    Console.WriteLine("\t|\t4.Exit                \t|");
                    Console.WriteLine("\t ===============================");
                    Console.WriteLine("");
                    Console.Write("\tPlease choose option: ");

                    menuChoice = Console.ReadLine();
                    if (menuChoice != "1" && menuChoice != "2" && menuChoice != "3" && menuChoice != "4") 
                        Console.WriteLine("Wrong Input! Please try again");
                }

                switch (Convert.ToInt32(menuChoice))
                {
                    case 1:
                        Input(todoList, 0);
                        break;


                    case 2:
                        Console.WriteLine("Please enter task name that you want to delete: ");
                        String TaskDeleteValue = Console.ReadLine();
                        Console.WriteLine(CheckDelete(TaskDeleteValue, todoList));
                        NumberTask(todoList);
                        MainProcess();
                        break;


                    case 3:
                        Console.WriteLine("Please enter task name that you want to update: ");
                        String taskUpdateValue = Console.ReadLine();
                        CheckUpdate(taskUpdateValue, todoList);
                        MainProcess();
                        break;


                    case 4:
                        goto ending;


                }

            }

        ending:
            Environment.Exit(0);

        }

    }
}
