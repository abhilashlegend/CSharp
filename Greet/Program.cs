namespace Greet;

class Program
{
    public static void Main(string[] args)
    {
        Greet("Anup");
        Greet("Abhishek");
        Greet("Akhil");
    }

    public static void Greet(string name)
    {
        Console.WriteLine($"Hi {name}, my friend!");
    }
}