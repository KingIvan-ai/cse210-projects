public class Dog : Animal
{
    public Dog(string name) : base(name, "Woof")
    {
    }

    public void Fetch()
    {
        Console.WriteLine($"{GetName()} fetches the ball!");
    }
}