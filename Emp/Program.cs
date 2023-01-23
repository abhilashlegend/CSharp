namespace Emp
{
    class Program
    {
        public static void Main(string[] args) {
            Employee Rohan = new Employee("Rohan", "Kammar", 50000.00);
            Rohan.Work();
            Rohan.Pause();

            Boss Manjunath = new Boss("Manjunath", "Hegde", 90000.00, "Hyundai i10");
            Manjunath.Work();
            Manjunath.Lead();

            Trainee Akshata = new Trainee("Akshata", "Kudachimath", 10000.00, 5.0f, 4.0f);
            Akshata.Work();
            Akshata.Learn();
            Akshata.Pause();

            Console.ReadLine();

        }
    }
}