using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign7
{
    public class Gun : Weapon, IShootable
    {
        public Gun()
        {
            this.Name = "Gun";
        }

        public void Shoot()
        {
            Console.WriteLine("Bang!");
        }
    }
}
