using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace MainArgs
{
    public class Calc
    {
        private double num1, num2, result;

        public  void input()
        {
            Console.WriteLine("Enter input number one");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter input number two");
            num2 = double.Parse(Console.ReadLine());
        }

        public double Add()
        {
            return num1 + num2;
        }

        public double Subtract()
        {
            return num1 - num2;
        }

        public double Multiply()
        {
            return num1 * num2;
        }

        public double Divide()
        {
            return num1 / num2;
        }
    }

    public class Operation : Calc
    {
        string op;
        public Operation(string args):base()
        {
            op = args;
        }

        public double opertion()
        {
            double result = 0;
            switch (op)
            {
                case "add":
                    this.input();
                    result = this.Add();
                    break;
                case "subtract":
                    this.input();
                    result = this.Subtract();
                    break;
                case "multiply":
                    this.input();
                    result = this.Multiply();
                    break;
                case "divide":
                    this.input();
                    result = this.Divide();
                    break;
                case null:
                    Console.WriteLine("Invalid Operation");
                    result = 0;
                    break;
            }
            return result;
        }




    }
    public class Program
    {
        
        public static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("No command passed");
            } 
            else
            {
                if (args[0] == "start")
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Console.WriteLine("Ending.....");
                }
                if (args[0] == "help")
                {
                    Console.WriteLine("This is a simple calculator program where you can use different command to add 2 numbers, " +
                        "subtract two numbers" +
                        "multiply two numbers" +
                        "divide two numbers. Example press command add to add.");
                }
                if (args[0] != null)
                {
                    Operation myOp = new Operation(args[0]);
                    double result = myOp.opertion();
                    Console.WriteLine("Result = " + result);
                }
                Console.ReadLine();
            }
            
        }

        
    }
}
