using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int length = 0;
        Console.Write("Please enter the numbers you would like to add to your list and enter 0 to stop: ");
        int num = int.Parse(Console.ReadLine());
        numbers.Add(num);
        length += 1;

        while (num != 0)
        {
            Console.Write(">:");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
            numbers.Add(num);
            length += 1;
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        int greatest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > greatest)
            {
                greatest = number;
            }
        }

        double average = (double)sum/length;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The greatest number in your list is {greatest}");
        numbers.Sort();
        Console.WriteLine($"Sorted list: {string.Join(",", numbers)}");
    }
}