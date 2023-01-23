using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, double salary) { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("I am working");
        }

        public void Pause()
        {
            Console.WriteLine("I am taking a break");
        }

    }
}
