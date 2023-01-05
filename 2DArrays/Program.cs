int[,] matrix =
{
   {1,2,3},
   {4,5,6},
   {7, 8,9}
};

Console.WriteLine("The elements in the matrix are as follows:");

foreach(int item in matrix)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------------------------------");

Console.WriteLine("Using nested for");

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = matrix[i, j] * 2;
        Console.WriteLine(matrix[i, j]);
    }
}

Console.WriteLine("---------------------------------------------------");

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i == j)
        Console.WriteLine(matrix[i, j]);
    }
}

Console.WriteLine("---------------------------------------------------");

int inc = 0;
int dec = 2;    

while(inc < matrix.GetLength(0))
{
    
        Console.WriteLine(matrix[inc, dec]);
        inc++;
        dec--;

}

Console.ReadLine();