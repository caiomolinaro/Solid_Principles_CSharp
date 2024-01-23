namespace LSP_Principle3;

internal class Bird
{
    public string Name { get; }

    public Bird(string name)
    {
        Name = name;
    }

    public virtual void Eat()
    {
        Console.WriteLine($"{Name} eating");
    }

    public virtual void LayEggs()
    {
        Console.WriteLine($"{Name} lay eggs");
    }
}