using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumeratorAndIEnumerable
{
    public class Dog
    {
        // the name of the dog
        public string Name { get; set; }

        // is this the naughty dog
        public bool IsNaughty { get; set; }

        // simple constructor
        public Dog(string name, bool isNaughty)
        {
            Name = name;
            IsNaughty = isNaughty;
        }

        // this method will print how many times the dog received
        public void GiveTreat(int numberoftreats)
        {
            Console.WriteLine("Dog: {0} said woff {1} times!.", Name, numberoftreats);
        }
    }
}
