namespace InheritanceDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Post p1 = new Post("Thanks for the birthday wishes", true, "Abhilash N");
            Console.WriteLine(p1.ToString());

            ImagePost Ip1 = new ImagePost("Check out my new shoes", "Abhilash N", "https://images.com/shoes", true);

            Console.WriteLine(Ip1.ToString());
            Console.ReadLine();
        }
    }
}