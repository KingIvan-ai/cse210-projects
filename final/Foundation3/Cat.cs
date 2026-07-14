public class Cat : Animal
{
    public Cat(string name) : base(name, "Meow")
    {
    }

    public void Purr()
    {
        Console.WriteLine($"{GetName()} purrs...");
    }
}