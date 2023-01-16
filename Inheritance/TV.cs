using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class TV : Device
    {
       public TV(bool isOn, string brand): base(isOn, brand)
        {

        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Broadcasting TV");
            }
            else
            {
                Console.WriteLine("Please switch on the TV to watch");
            }
        }
    }
}
