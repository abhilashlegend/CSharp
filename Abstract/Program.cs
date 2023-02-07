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

                Cube cb = shape as Cube;
                if(cb == null)
                {
                    Console.WriteLine("This shape is no cube");
                }
                if(shape is Cube)
                {
                    Console.WriteLine("This is a cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} has a Volume of {1}", cube2.Name, cube2.Volume());
            }

            Console.ReadLine();
        }
    }
}