namespace VirtualOverride
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dog tommy = new Dog("Tommy", 2);
            tommy.MakeSound();
            tommy.Eat();
            tommy.Play();
            Console.ReadLine();
        }
    }
}