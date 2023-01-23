using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    public class Trainee: Employee
    {
        public float WorkingHours { get; set; }
        public float SchoolHours { get; set; }

        public Trainee(string firstName, string lastName, double salary, float workingHours, float schoolHours): base(firstName, lastName, salary)
        {
            WorkingHours = workingHours;
            SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("I learn for {0} hours", this.SchoolHours);
        }

        public new void Work()
        {
            Console.WriteLine("I work for {0} hours", this.WorkingHours);
        }
    }
}
