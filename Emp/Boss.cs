using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp
{
    public class Boss : Employee
    {
        public string CompanyCar { get; set; }

        public Boss(string firstName, string lastName, double salary, string companyCar):base(firstName, lastName, salary)
        {
            CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("I'm the Boss");
        }
    }
}
