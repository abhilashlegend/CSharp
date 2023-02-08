namespace ReadTxtFile
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + @"\Note.txt");

            Console.WriteLine("Your file content is {0}", text);

            string[] lines = System.IO.File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Note.txt");

            Console.WriteLine("Contents of text file =");

            foreach(string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            
            Console.ReadLine();
        }
    }
}