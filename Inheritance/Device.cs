using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Device
    {
        public bool IsOn;

        public string Brand;


        public Device(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        public void SwitchOn()
        {
            this.IsOn = true;
            Console.WriteLine("Device switched On");
        }

        public void SwitchOff()
        {
            this.IsOn = false;
            Console.WriteLine("Device switched Off");
        }

    }
}
