
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

            // Updating A Dictionary 
            string keyToUpdate = "HR";
            if(employeeDirectory.ContainsKey(keyToUpdate))
            {
                employeeDirectory[keyToUpdate] = new Employee("HR", "Anusha Patel", 26, 18);
                Console.WriteLine("Employee with Role {0} was updated!", keyToUpdate);
            } else
            {
                Console.WriteLine("Employee with role {0} was not found", keyToUpdate);
            }

            // Remove A record from dictionary
            string keyToRemove = "Intern";

            if(employeeDirectory.Remove(keyToRemove))
            {
                Console.WriteLine("Employee with role {0} was removed", keyToRemove);
            } else
            {
                Console.WriteLine("Employee with role {0} was not found", keyToRemove);
            }

            for(int i = 0; i < employeeDirectory.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = employeeDirectory.ElementAt(i);

                Console.WriteLine("Employee Name {0}", keyValuePair.Value.Name);
                Console.WriteLine("Employee Age {0}", keyValuePair.Value.Age);
                Console.WriteLine("Employee Role {0}", keyValuePair.Value.Role);
                Console.WriteLine("Employee Salary {0}", keyValuePair.Value.Salary);
            }

            Console.ReadLine();
        }

    }


}