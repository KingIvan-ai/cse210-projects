using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        float percentageGrade = float.Parse(Console.ReadLine());

        string letter;

        if (percentageGrade >= 90)
            letter = "A";
        else if (percentageGrade >= 80)
            letter = "B";
        else if (percentageGrade >= 70)
            letter = "C";
        else if (percentageGrade >= 60)
            letter = "D";
        else
            letter = "F";

        Console.WriteLine($"Your letter grade is: {letter}");

        if (percentageGrade >= 70)
            Console.WriteLine("Congratulations, you passed the course!");
        else
            Console.WriteLine("You didn't pass this time, but keep going — you've got this!");
    }
}