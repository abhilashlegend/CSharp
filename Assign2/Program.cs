using System;

namespace Assign2
{
    public class Method
    {
        // Place for your methods
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);

        }

        public static string LowUpper(string str)
        {
            string result = str.ToLower() + str.ToUpper();
            return result;
        }

        public static void Count(string str)
        {
            Console.WriteLine(str.Count());
        }
    }
}

