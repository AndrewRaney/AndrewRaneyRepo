// Module 3 Discussion: C# Class Example

// Creating a class with fields, properties, constructor, and method
public class Octopus
{
    public string Name { get; }
    public int Legs { get; } = 8;

    // Constructor
    public Octopus(string name)
    {
        Name = name;
    }

    // Method
    public void DisplayInfo()
    {
        Console.WriteLine($"The octopus named {Name} has {Legs} legs.");
    }
}

// Main Program to create an instance of Octopus
class Program
{
    static void Main()
    {
        // Object initialization
        Octopus o = new Octopus("Jack");
        o.DisplayInfo();
    }
}
