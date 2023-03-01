namespace DelegateExample
{
    delegate void DelegateSendMessage(string msg);
    public class Program
    {
        public static void Main(string[] args)
        {
            DelegateSendMessage dsm = new DelegateSendMessage(SendMessage);
            dsm("Hello from delegate");
            Console.ReadLine();
        }

        public static void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
