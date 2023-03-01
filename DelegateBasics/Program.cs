namespace DelegateBasics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Abhilash",
                "Abhishek",
                "Akhil",
                "Arjun",
                "Basavraj",
                "Chetan",
                "Manjunath",
                "Nikhil",
                "Nagraj",
                "Nilesh",
                "Srinivas",
                "Rajkishor",
                "Rohit",
                "Vinay"
            };

            Console.WriteLine("---------------- Before Filter -----------------------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.RemoveAll(FilterNames);

            Console.WriteLine("------------------ After Filter ------------------------");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        public static bool FilterNames(string name)
        {
            return name.Contains("i");
        }
    }
}