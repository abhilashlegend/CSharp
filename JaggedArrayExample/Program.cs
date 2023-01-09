namespace JaggedArrayExample;

class Program
{
    public static void Main(string[] args)
    {
        string[][] jaggedArray =
        {
            new string[] {"Abhilash", "Shilpa"},
            new string[] {"Raj Kishor", "Anusha" },
            new string[] {"Abhishek", "Rashmi"},
            new string[] {"Kiran", "Renuka"}
        };

        Console.WriteLine("{0} I would like to introduce to {1}", jaggedArray[0][0], jaggedArray[1][0]);
        Console.WriteLine("{0} I would like to indtroduce to {1}", jaggedArray[0][1], jaggedArray[1][1]);
        Console.WriteLine("{0} I would like to indtroduce to {1}", jaggedArray[0][0], jaggedArray[2][0]);
        Console.WriteLine("{0} I would like to indtroduce to {1}", jaggedArray[0][1], jaggedArray[2][1]);
        Console.WriteLine("{0} I would like to indtroduce to {1}", jaggedArray[0][0], jaggedArray[3][0]);
        Console.WriteLine("{0} I would like to indtroduce to {1}", jaggedArray[0][1], jaggedArray[3][1]);
        Console.ReadLine();
    }
}