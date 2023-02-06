namespace Polymorphism
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
                new BMW(200, "silver", "Z4"),
                new Audi(220, "blue", "A4")
            };

            foreach(Car car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }

            BMW bmwM3 = new BMW(500, "red", "M3");
            Car a6 = new Audi(330, "white", "A6");
            bmwM3.ShowDetails();
            a6.ShowDetails();

            Console.ReadLine();
        }
    }
}