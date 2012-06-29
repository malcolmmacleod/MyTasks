using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TomatoTimer.Domain;
using TomatorTimer.Service;

namespace TomatoTimer.ConsoleApp

{
    class Program
    {
        private static bool _commandProcessed;

        static void Main(string[] args)
        {
            string command = DisplayMenu();
            _commandProcessed = false;


            if (String.IsNullOrEmpty(command))
            {
                Console.WriteLine("Invalid command");
            }
            else
            {
                switch (command.ToUpper())
                {
                    case "ADD":
                        AddDefaultTasks();
                        break;
                    case "DEL":
                        DeleteTasks();
                        break;
                    default:
                        Console.WriteLine("Invalid Command");
                        Console.ReadLine();
                        break;
                }
            }

        }

        private static string DisplayMenu()
        {
            Console.WriteLine("Enter your command : ");
            Console.WriteLine(" ADD - add default entries");
            Console.WriteLine(" DEL - remove tasks");

            string command = Console.ReadLine();

            return command;
        }

        private static void AddDefaultTasks()
        {
            Console.WriteLine("Adding default tasks...");

            var taskService = new TaskService();
            taskService.AddTask(new Task ("New Task", Priority.None));
            taskService.AddTask(new Task ("New Task 2", Priority.None));

            Console.WriteLine("Tasks Added");
            Console.ReadLine();
        }

        private static void DeleteTasks()
        {
            Console.WriteLine("Deleting tasks...");

            var taskService = new TaskService();

            var allTasks = taskService.GetTasks();

            allTasks.Select(t => taskService.RemoveTask(t.Id));

            Console.WriteLine("Tasks Deleted");
            Console.ReadLine();
        }
    }
}
