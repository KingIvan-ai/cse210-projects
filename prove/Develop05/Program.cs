// This program exceeds the core requirements by adding a leveling system.
// As the user earns points they level up through different titles:
// Novice, Apprentice, Warrior, Hero, and Legend.
// This adds a gamification element that gives the user a sense of
// progression beyond just seeing their point total.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            manager.DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.ListGoals();
            }
            else if (choice == "3")
            {
                manager.SaveGoals();
            }
            else if (choice == "4")
            {
                manager.LoadGoals();
            }
            else if (choice == "5")
            {
                manager.RecordEvent();
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