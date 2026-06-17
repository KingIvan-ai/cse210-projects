using System;

// This program exceeds the core requirements by keeping a log of how many times
// each activity was completed during the session. When the user quits, the program
// displays a summary showing how many times they did each activity.

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine() ?? "";

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                reflectingCount++;
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.WriteLine();
                Console.WriteLine("Here is a summary of your session:");
                Console.WriteLine($"Breathing Activity completed: {breathingCount} times");
                Console.WriteLine($"Reflecting Activity completed: {reflectingCount} times");
                Console.WriteLine($"Listing Activity completed: {listingCount} times");
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("That is not a valid choice.");
            }
        }
    }
}