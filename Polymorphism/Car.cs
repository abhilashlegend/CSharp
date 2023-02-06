using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Car
    {
        public int Hp { get; set; }

        public string Color { get; set; }

        public Car(int hp, string color)
        {
            this.Hp = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("The car is {0} and is {1}", this.Hp, this.Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("The car is repaired");
        }
    }
}
