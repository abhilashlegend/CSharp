namespace ReadTxtFile
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + @"\Note.txt");

            Console.WriteLine("Your file content is {0}", text);
            
            Console.ReadLine();
        }
    }
}