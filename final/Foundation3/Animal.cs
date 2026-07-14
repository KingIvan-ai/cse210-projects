public class Animal
{
    private string _name;
    private string _sound;

    public Animal(string name, string sound)
    {
        _name = name;
        _sound = sound;
    }

    public string GetName()
    {
        return _name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{_name} says {_sound}");
    }
}