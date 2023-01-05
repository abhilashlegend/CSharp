int[,] matrix = new int[,]
{
    {1, 2, 3 },
    {4, 5, 6 },
    {7, 8, 9 }
};

Console.WriteLine("This is an example of 2D array {0}", matrix[1, 1]);
Console.WriteLine("The rank of the array is {0}", matrix.Rank);


string[,,] threeD = {
    {
        {
            "Abhilash", "Akhil", "Abhishek"
        },
        {
            "Bhasavraj", "Basu", "Banu"
        },
        {
            "Chetan", "Chaitra", "Chandani"
        } 
    }
};

Console.WriteLine("This is an example of 3 D Array. Lets pick Banu, {0}", threeD[0, 1, 2]);


Console.ReadLine();