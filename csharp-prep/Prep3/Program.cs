using System;
using System.Net;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        
        // Random randomGenerator = new Random();
        // int magic_number = randomGenerator.Next(1, 100);
        // Console.Write("What is your guess: ");
        // int guess = int.Parse(Console.ReadLine());
        // int number_guesses = 1;
        string play_again = "yes";

        while (play_again == "yes")
        {
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 100);
            Console.Write("What is your guess: ");
            int guess = int.Parse(Console.ReadLine());
            int number_guesses = 1;
            while (guess != magic_number)
            {
                if (guess < magic_number)
                {
                    Console.WriteLine("Higher");
                }

                if (guess > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                Console.Write("Guess again: ");
                guess = int.Parse(Console.ReadLine());
                number_guesses = number_guesses+1;

            }

            if (guess == magic_number)
            {
                Console.WriteLine("YOU WIN!");
                Console.WriteLine($"It took you {number_guesses} guesses to win");
            }
            Console.Write("Would you like to play again?> ");
            string response = Console.ReadLine();
            play_again = response;
    }
    }
}