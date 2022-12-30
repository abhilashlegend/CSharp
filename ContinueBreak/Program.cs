using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Main(string[] args)
        {
            int i = -10;

            while (true)
            {
                if(i % 3 == 0)
                {
                    i++;
                    continue;
                }

                if(i == 10) break;
                if (i % 6 == 0)
                {
                    break;
                }
                Console.WriteLine(i++);
            }
        }
    }
}
