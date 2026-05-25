using System;

// This program exceeds the core requirements by adding a keyword search feature.
// The user can search through all journal entries by entering a keyword, and any
// entries that contain that keyword in either the prompt or the response will be displayed.
// This helps solve the problem of not being able to find old entries easily.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                journal.SaveToFile();
            }
            else if (choice == "4")
            {
                journal.LoadFromFile();
            }
            else if (choice == "5")
            {
                journal.SearchEntries();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("That is not a valid choice.");
            }
        }
    }
}