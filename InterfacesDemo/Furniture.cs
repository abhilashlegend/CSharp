using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Furniture
    {
        public string Color { get; set; }

        public string Material { get; set; }

        public Furniture() {
            Color = "Brown";
            Material = "Wood";
        }

        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
