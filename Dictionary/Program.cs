
namespace Dictionary
{
    class Program
    {

        public static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                {1, "One" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" }
            };

            Console.WriteLine(myDictionary.Count);

            Employee[] employees =
            {
                new Employee("CEO", "Liza Clay", 95, 200),
                new Employee("Manager", "Ronald Bowes",35, 25),
                new Employee("HR", "Lora Homes", 32, 21),
                new Employee("Secretary", "Moira Luis", 28, 18),
                new Employee("Lead Developer", "Abhilash N", 55, 35),
                new Employee("Intern", "Nora Jones", 22, 8)
             };

            Dictionary<string, Employee> employeeDirectory = new Dictionary<string, Employee>();
            foreach (Employee employee in employees)
            {
                employeeDirectory.Add(employee.Role, employee);
            }

            Console.WriteLine("Enter the role of the employee");
            string input = Console.ReadLine();
            if(employeeDirectory.ContainsKey(input))
            {
                Employee emp = employeeDirectory[input];
                Console.WriteLine("Name: {0}", emp.Name);
                Console.WriteLine("Age: {0}", emp.Age);
                Console.WriteLine("Salary : {0}", emp.Salary);
            } else
            {
                Console.WriteLine("The role does not exists");
            }

            Console.ReadLine();
        }

    }


}