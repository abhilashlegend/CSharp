using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Car
    {
        public int Hp { get; set; }

        public string Color { get; set; }

        // Has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo(); 

        public void SetCarIDInfo(int idNum, string Owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = Owner;
        }

        public void GetCarIDinfo()
        {
            Console.WriteLine("The car has an ID of {0} and is owned by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }
        public Car(int hp, string color)
        {
            this.Hp = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("The car is {0} and is {1}", this.Hp, this.Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("The car is repaired");
        }
    }
}
