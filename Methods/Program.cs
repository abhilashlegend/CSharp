namespace Methods;

class Program
{
    public static void Main(string[] args)
    {
        Message();
        CustomMessage("Hi this is Abhilash");
    }

    public static void Message()
    {
        Console.WriteLine("Welcome to C# Course");
        Console.Read();
    }

    public static void CustomMessage(string message)
    {
        Console.WriteLine(message);
        Console.Read();
    }
}