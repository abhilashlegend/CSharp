using System;
using System.Collections.Generic;
namespace Lists
{
    public class Program
    {

        public static void Main(string[] args)
        {
            List<int> nums = Solution();
            foreach(var num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

        }

        public static List<int> Solution()
        {
            // TODO: write your solution here
            List<int> list = new List<int>();

            for(int i = 100; i <= 170; i++)
            {
                if(i % 2 == 0)
                list.Add(i);
            }
            return list;
        }

    }
}
