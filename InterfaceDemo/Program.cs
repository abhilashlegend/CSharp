using InterfaceDemo;

namespace IntefaceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ticket t1 = new Ticket(4);
            Ticket t2 = new Ticket(4);

            Console.WriteLine(t1.Equals(t2));

            Console.ReadLine();

        }
    }
}