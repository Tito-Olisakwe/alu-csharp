using System;
using System.Collections.Generic;
using InventoryLibrary;

namespace InventoryManager
{
    class InventoryManager
    {
        static JSONStorage storage;

        static void Main(string[] args)
        {
            storage = new JSONStorage();
            Console.WriteLine("Inventory Manager");
            Console.WriteLine("-------------------------");
            PrintCommands();

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine().Trim();
                string[] tokens = input.Split(' ');

                if (tokens.Length == 0)
                {
                    continue;
                }

                string command = tokens[0].ToLower();
                switch (command)
                {
                    case "classnames":
                        PrintClassNames();
                        break;
                    case "all":
                        if (tokens.Length == 1)
                            PrintAllObjects();
                        else if (tokens.Length == 2)
                            PrintObjectsByClassName(tokens[1]);
                        else
                            PrintError("Invalid command format");
                        break;
                    case "create":
                        if (tokens.Length == 2)
                            CreateObject(tokens[1]);
                        else
                            PrintError("Invalid command format");
                        break;
                    case "show":
                        if (tokens.Length == 3)
                            ShowObject(tokens[1], tokens[2]);
                        else
                            PrintError("Invalid command format");
                        break;
                    case "update":
                        if (tokens.Length == 3)
                            UpdateObject(tokens[1], tokens[2]);
                        else
                            PrintError("Invalid command format");
                        break;
                    case "delete":
                        if (tokens.Length == 3)
                            DeleteObject(tokens[1], tokens[2]);
                        else
                            PrintError("Invalid command format");
                        break;
                    case "exit":
                        return;
                    default:
                        PrintError("Unknown command");
                        break;
                }
            }
        }

        static void PrintCommands()
        {
            Console.WriteLine("<ClassNames> show all ClassNames of objects");
            Console.WriteLine("<All> show all objects");
            Console.WriteLine("<All [ClassName]> show all objects of a ClassName");
            Console.WriteLine("<Create [ClassName]> a new object");
            Console.WriteLine("<Show [ClassName object_id]> an object");
            Console.WriteLine("<Update [ClassName object_id]> an object");
            Console.WriteLine("<Delete [ClassName object_id]> an object");
            Console.WriteLine("<Exit>");
        }

        static void PrintClassNames()
        {
            foreach (var key in storage.All().Keys)
            {
                string className = key.Split('.')[0];
                Console.WriteLine(className);
            }
        }

        static void PrintAllObjects()
        {
            foreach (var obj in storage.All().Values)
            {
                Console.WriteLine(obj);
            }
        }

        static void PrintObjectsByClassName(string className)
        {
            foreach (var key in storage.All().Keys)
            {
                if (key.StartsWith(className + "."))
                {
                    Console.WriteLine(storage.All()[key]);
                }
            }
        }

        static void CreateObject(string className)
        {
            // Implementation for creating a new object
            Console.WriteLine("Creating a new " + className);
            // Add logic to create object and save it
        }

        static void ShowObject(string className, string id)
        {
            string key = className + "." + id;
            if (storage.All().ContainsKey(key))
            {
                Console.WriteLine(storage.All()[key]);
            }
            else
            {
                PrintError("Object " + id + " could not be found");
            }
        }

        static void UpdateObject(string className, string id)
        {
            string key = className + "." + id;
            if (storage.All().ContainsKey(key))
            {
                // Implementation for updating the object
                Console.WriteLine("Updating " + key);
                // Add logic to update object and save it
            }
            else
            {
                PrintError("Object " + id + " could not be found");
            }
        }

        static void DeleteObject(string className, string id)
        {
            string key = className + "." + id;
            if (storage.All().ContainsKey(key))
            {
                storage.All().Remove(key);
                storage.Save();
                Console.WriteLine("Deleted " + key);
            }
            else
            {
                PrintError("Object " + id + " could not be found");
            }
        }

        static void PrintError(string message)
        {
            Console.WriteLine("Error: " + message);
        }
    }
}
