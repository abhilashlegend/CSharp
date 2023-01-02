using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Geometry
{
    class Cylinder : Shape
    {
        private double radius;
        private double height;

        public double Radius { get; set; }

        public double Height { get; set; }

        public override double getVolume()
        {
            return pi * Radius * Radius * Height;
        }
    }
}
