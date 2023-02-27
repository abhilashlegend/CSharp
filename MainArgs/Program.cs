namespace MainArgs
{
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
            }
            
        }
    }
}
