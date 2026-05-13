using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int GetUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        int fav_number = int.Parse(Console.ReadLine());
        return fav_number;

    }

    static void GetUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number*number;
        return square;
    }

    static void DisplayResult(string userName, int square, int userBirthYear)
    {
        int age = 2026 - userBirthYear;
        Console.WriteLine($"{userName}, the square of your number is {square}.");
        Console.WriteLine($"{userName}, you will turn {age} this year.");
    }

    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = GetUserName();
        int userNumber = GetUserNumber();
        int birthYear;
        GetUserBirthYear(out birthYear);
        int square = SquareNumber(userNumber);
        DisplayResult(userName, square, birthYear);
    }
}