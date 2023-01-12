using System.Collections.Generic

namespace Assign6
{
    class Program
    {
        public static void Main(string[] args)
        {
            string result = Convert(3);
            Console.WriteLine(result);
            Console.ReadLine();
            
        }

        public static string Convert(int i)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
            {
                {0, "zero" },
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" }
            };

            if(keyValuePairs.ContainsKey(i))
            {
                return keyValuePairs[i].ToString();
            } else
            {
                return "nope";
            }
        }
    }
}