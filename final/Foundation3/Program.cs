using System;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Rex");
        Cat cat = new Cat("Whiskers");

        dog.MakeSound();
        dog.Fetch();

        Console.WriteLine();

        cat.MakeSound();
        cat.Purr();
    }
}