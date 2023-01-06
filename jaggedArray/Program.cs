using System.Net.Http.Headers;

int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[3] { 1, 2, 3 };
jaggedArray[1] = new int[2] { 1, 2 };
jaggedArray[2] = new int[1] { 1 };

for(int i = 0; i < jaggedArray.Length; i++)
{
    Console.WriteLine("Elements at {0}", i);
    for(int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.WriteLine("{0}", jaggedArray[i][j]);
    }
}

// Alternative method
int[][] jaggedArray2 =
{
    new int[3] {1, 2, 3},
    new int[5] {1, 2, 3, 4, 5}
};

Console.ReadLine();