using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Radio : Device
    {
        public Radio(bool isOn, string brand) : base(isOn, brand) { 
        
        }

        public void ListenToRadio()
        {
            if(IsOn)
            {
                Console.WriteLine("Listening to Radio");
            }
            else
            {
                Console.WriteLine("Please switch on the radio to listen");
            }
        }
    }
}
