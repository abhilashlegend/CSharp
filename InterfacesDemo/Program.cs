namespace InterfacesDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            // creating two objects of type car
            Car damagedCar = new Car("Blue", 80f);

            /* Add the two chairs to the IDestroyable list of the car
             * so that when we destroy the car the destroyable objects
             * that are near the car will get destroyed as well */
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            damagedCar.Destroy();

            Console.ReadLine();




        }
    }
}