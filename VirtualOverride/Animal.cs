using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string Name, int Age) { 
            this.Name = Name;
            this.Age = Age;
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{this.Name} is eating");
        }

        public virtual void MakeSound()
        {

        }

        public virtual void Play()
        {
            Console.WriteLine($"{this.Name} is playing.");
        }
    }
}
