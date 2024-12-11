using System;
using System.Collections.Generic;

namespace MiniProjects
{
    class ToDo
    {
        static void addList(List<string> list, string element)
        {
            list.Add(element);
            Console.WriteLine($"Task added: {element}");
        }

        static void removeList(List<string> list, string element)
        {
            if (list.Contains(element))
            {
                list.Remove(element);
                Console.WriteLine($"Task removed: {element}");
            }
            else
            {
                Console.WriteLine($"Task not found: {element}");
            }
        }

        static void listTasks(List<string> list)
        {
            Console.WriteLine("Tasks:");
            if (list.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                foreach (var task in list)
                {
                    Console.WriteLine("- " + task);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the TO-DO LIST program");

            List<string> tasks = new List<string>();
            List<string> options = new List<string>()
            {
                "1) Add task",
                "2) Remove task",
                "3) List tasks",
                "4) Exit"
            };

            bool run = true;

            while (run)
            {
                Console.WriteLine("\nChoose an option:");
                foreach (var opt in options)
                {
                    Console.WriteLine(opt);
                }

                Console.Write("Your choice: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task: ");
                        string taskToAdd = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(taskToAdd))
                        {
                            addList(tasks, taskToAdd);
                        }
                        else
                        {
                            Console.WriteLine("Task cannot be empty.");
                        }
                        break;

                    case 2:
                        Console.Write("Enter task to remove: ");
                        listTasks(tasks);
                        string taskToRemove = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(taskToRemove))
                        {
                            removeList(tasks, taskToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Task cannot be empty.");
                        }
                        break;

                    case 3:
                        listTasks(tasks);
                        break;

                    case 4:
                        Console.WriteLine("Exiting program. Goodbye!");
                        run = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option! Please choose a valid number.");
                        break;
                }
            }
        }
    }
}