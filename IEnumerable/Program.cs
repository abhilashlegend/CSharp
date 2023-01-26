namespace IEnumerable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEnumerable<int> unknownCollection;
            unknownCollection = getCollection(1);

            foreach(int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            Console.WriteLine(" ");

            unknownCollection = getCollection(2);

            foreach(int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            Console.WriteLine(" ");

            unknownCollection = getCollection(3);

            foreach(int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }

            Console.ReadLine();
        }

        public static IEnumerable<int> getCollection(int option)
        {
            if(option == 1)
            {
                List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
                return list;
            }
            else if(option == 2)
            {
                Queue<int> que = new Queue<int>();
                que.Enqueue(6);
                que.Enqueue(7);
                que.Enqueue(8);
                que.Enqueue(9);
                que.Enqueue(10);
                return que;
            } 
            else
            {
                return new int[] { 11, 12, 13, 14 };
            }
        }
    }
}