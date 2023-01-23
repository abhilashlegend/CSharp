using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Ticket : IEquatable<Ticket>
    {
        public int Duration { get; set; }

        public Ticket(int duration)
        {
            Duration = duration;
        }

        public bool Equals(Ticket other)
        {
            return this.Duration == other.Duration; 
        }
    }
}
