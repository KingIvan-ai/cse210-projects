using System;

// This program exceeds the core requirements in two ways:
// 1. It includes a library of scriptures and selects one at random each time
//    the program runs, so the user gets a different scripture to memorize each time.
// 2. The program tracks whether all words are hidden and automatically ends
//    when the scripture is fully hidden, so the user knows when they are done.

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight"),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me")
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Great job!");
                break;
            }

            Console.Write("Press enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine() ?? "";

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}