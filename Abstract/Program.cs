namespace Abstract
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shape[] shapes = { new Cube(3), new Sphere(5) };

            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("The shape is {0} and has a volume of {1}", shape.Name, shape.Volume());
            }

            Console.ReadLine();
        }
    }
}