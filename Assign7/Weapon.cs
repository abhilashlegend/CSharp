using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign7
{
    public class Weapon
    {
        public string Name { get; set; }

        public Weapon()
        {
            Name = "Knife";
        }

        public Weapon(string name)
        {
            Name = name;
        }

        public void Label()
        {
            Console.WriteLine($"This is {this.Name}!");
        }


    }
}
