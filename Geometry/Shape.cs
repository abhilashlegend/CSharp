using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    abstract class Shape
    {
        private double volume;
        const double pi = 3.142;

        public abstract double getVolume();


    }

    class Rectangle : Shape
    {
        private double length;
        private double width;
        private double height;

        public double Length { get; set; }

        public double Width { 
            get
            {
                return this.width;
            }
            set
            {
                if(value < 0)
                {
                    this.width = -value;
                } 
                else
                {
                    this.width = value;
                }
                
            }
        }

        public double Height { get; set; }

        public override double getVolume()
        {
            return  Length * Width * Height;
        }
    }

    class Cube : Shape
    {
        private double length;

        public double Length
        {
            get { return this.length; }

            set
            {
                this.length = value;
            }
        }

        public override double getVolume()
        {
            return length * length * length;
        }
    }
}
