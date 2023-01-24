using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Vechicle
    {
        public string Color { get; set; }
        public float Speed { get; set; }

        public Vechicle()
        {
            this.Color = "White";
            this.Speed = 120.0f;
        }

        public Vechicle(string color, float speed)
        {
            Color = color;
            Speed = speed;
        }
    }
}
