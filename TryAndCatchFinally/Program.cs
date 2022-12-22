using System;

namespace TryAndCatchFinally;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number");
        string num1 = Console.ReadLine();
        Console.WriteLine("Please enter a second number");
        string num2 = Console.ReadLine();
        double result = 0.0;

        Console.WriteLine("Please enter \"1\" for Addition");
        Console.WriteLine("Please enter \"2\" for Subtraction");
        Console.WriteLine("Please enter \"3\" for Multiplication");
        Console.WriteLine("Please enter \"4\" for Division");

        string op = Console.ReadLine(); 

        try
        {
            switch (op)
            {
                case "1":
                    result = double.Parse(num1) + double.Parse(num2);
                    break;
                case "2":
                    result = double.Parse(num1) - double.Parse(num2);
                   break;
                case "3":
                    result = double.Parse(num1) * double.Parse(num2);
                    break;
                case "4":
                    result = double.Parse(num1) / double.Parse(num2);   
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }

            Console.WriteLine(result);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally { Console.WriteLine("Program finished"); }
        
    }
}