namespace OrderQueue
{
    public class Program
    {
        static Order[] ReceiveOrdersFromBranch1()
        {
            Order[] orders = new Order[]
             {
                new Order(1, 2),
                new Order(2, 3),
                new Order(3, 4),
             };
            return orders;
        }

        static Order[] ReceiveOrdersFromBranch2()
        {
            Order[] orders = new Order[]
             {
                new Order(4, 5),
                new Order(5, 4),
                new Order(6, 10),
             };
            return orders;
        }
        public static void Main(string[] args)
        {
            Queue<Order> ordersQueue = new Queue<Order>();

            foreach(Order o in ReceiveOrdersFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in ReceiveOrdersFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while(ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();

                currentOrder.ProcessOrder();

            }
        }
    }
}