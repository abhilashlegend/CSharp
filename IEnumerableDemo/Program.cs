namespace IEnumerableDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 23, 23, 34, 2 };
            Console.WriteLine("The sum is {0}", voidSumCollection(nums));

            int[] numarray = new int[] { 23, 22, 2 };
            Console.WriteLine("The sum of array is {0}", voidSumCollection(numarray));

            Console.ReadLine();

        }

        public static int voidSumCollection(IEnumerable<int> collection)
        {
            int sum = 0;

            foreach(int num in collection)
            {
                sum += num;
            }
            return sum;
        }
    }
}