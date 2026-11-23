using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Hashtable tab = new Hashtable();

        while (true)
        {
            Console.WriteLine("[1] Add Data");
            Console.WriteLine("[2] Delete Data");
            Console.WriteLine("[3] Display Data");
            Console.WriteLine("[4] Exit");
            Console.WriteLine("Enter your choice: ");

            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter a key:");
                    string key = Console.ReadLine();
                    Console.WriteLine("Enter a value:");
                    string value = Console.ReadLine();

                    if (key != null && value != null)
                    {
                        tab[key] = value;
                        Console.WriteLine("Data added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Key and value cannot be null.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Enter key to delete:");
                    string deleteKey = Console.ReadLine();

                    if (tab.ContainsKey(deleteKey))
                    {
                        tab.Remove(deleteKey);
                        Console.WriteLine("Data deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Key not found.");
                    }
                    break;
                case "3":
                    if (tab.Count == 0)
                    {
                        Console.WriteLine("Hashtable is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Data in the hashtable: ");
                        foreach (DictionaryEntry entry in tab)
                        {
                            Console.WriteLine("Key: {0}, Value: {1}", entry.Key, entry.Value);
                        }
                    }
                    break;
                case "4":
                    return;
            }
        }
    }
}


