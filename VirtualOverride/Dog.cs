using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    public class Dog: Animal
    {
        public bool isHappy;
        public Dog(string Name, int Age) : base(Name, Age) {
            isHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void Play()
        {
            if (isHappy)
            {
                base.Play();
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof Woof");
        }
    }
}
