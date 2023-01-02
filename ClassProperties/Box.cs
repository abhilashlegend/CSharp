using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProperties
{
    class Box
    {
        private int length;
        private int width;
        private int height;
        private int volume;

        public void setLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Invalid length. Length should be greater than 0");
            }
            this.length = length;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public void setHeight(int height) { this.height = height; }

        private void setVolume()
        {
            this.volume = this.length * this.width * this.height;
        }

        public void getBoxInfo()
        {
            this.setVolume();
            Console.WriteLine($"The length of the box is {this.length}, width is {this.width}, height is {this.height}. So the volume is {this.volume}");
        }


        public int getLength() { return length; }
        public int getWidth() { return width; }
        public int getHeight() { return height; }
        public int getVolume() { return volume; }

    }

}
