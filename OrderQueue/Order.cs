using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderQueue
{
    public class Order
    {
        public int Id { get; set; }

        public int Qty { get; set; }

        public Order(int id, int qty)
        {
            this.Id= id;
            this.Qty = qty;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {Id} processed!.");
        }
    }
}
