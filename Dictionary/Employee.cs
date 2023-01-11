using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // Constructor
        public Employee(string role, string name, int age, float Rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = Rate;
        }
    }
}
