namespace structExample {

    public struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releasedate;

        public void displayInfo()
        {
            Console.WriteLine("The name of the game is : {0}", name);
            Console.WriteLine("The developer of the game is : {0}", developer);
            Console.WriteLine("The rating of the game is : {0}", rating);
            Console.WriteLine("The release date of the game is : {0}", releasedate);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Angry Birds";
            game1.developer = "Rovio";
            game1.rating = 9;
            game1.releasedate = "2010";

            game1.displayInfo();
            Console.ReadLine();
        }
    }
}