using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    public class Car : Vechicle, IDestroyable
    {
        public Car(string color, float speed): base(color, speed) {
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public string DestructionSound { get; set; }    

        public List<IDestroyable> DestroyablesNearby { get; set; }

        public void Destroy()
        {
            Console.WriteLine("Playing  destruction sound {0}", DestructionSound);
            Console.WriteLine("Create Fire");

            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }

    }
}
