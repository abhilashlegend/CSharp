using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BMW: Car
    {
        public string brand = "BMW";

        public string Model { get; set; }

        public BMW(int hp, string color, string model): base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("The BMW is {0} model which is {1} HP and the color is {2}", this.Model, this.Hp, this.Color);
        }

        public override void Repair()
        {
            Console.WriteLine("{0} {1} is repaired", this.brand, this.Model);
        }

    }
}
