using System.IO;

namespace WriteTextFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Method 1:
            string[] lines = { "first line", "second line", "third line" };

            File.WriteAllLines(Directory.GetCurrentDirectory() + @"\textFile.txt", lines);

            Console.ReadLine();

            // Method 2: 
            Console.WriteLine("Please give the file a name");
            string filename = Console.ReadLine();
            Console.WriteLine("Please enter the text file");
            string input = Console.ReadLine();
            File.WriteAllText(Directory.GetCurrentDirectory() + @"\" + filename + ".txt", input);
        }
    }
}