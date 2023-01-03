namespace Assign4;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        GetOdd(array);
        GetEven(array);

        Console.ReadLine();
    }

    public static void GetOdd(int[] Array)
    {
       foreach(int odd in Array)
        {
            if(odd % 2 != 0)
            {
                Console.WriteLine(odd);
            }
        }
    }

    public static void GetEven(int[] Array)
    {
        foreach (int even in Array)
        {
            if (even % 2 == 0)
            {
                Console.WriteLine(even);
            }
        }
    }
}