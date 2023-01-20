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

            VideoPost vp1 = new VideoPost("Check out my vlog", "Abhilash N", "https://youtube.com/sdfsdf0", 10.23, true);
            Console.WriteLine(vp1.ToString());
            vp1.Play();
            Console.WriteLine("Press any key to stop the video!");
            Console.ReadKey();
            vp1.Stop();

            Console.ReadLine();
        }
    }
}