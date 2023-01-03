//Method 1:
using System.Transactions;

int[] myArray = new int[5];

myArray[0] = 10;
myArray[1] = 11;
myArray[2] = 12;
myArray[3] = 13;
myArray[4] = 14;

Console.WriteLine("Enter a number 0 to 4 to access array value");
int ind = int.Parse(Console.ReadLine());
Console.WriteLine(myArray[ind]);

// Method 2:
int[] marks = { 23, 34, 22, 33, 12 };
Console.WriteLine("The marks are as follows:");
foreach(int mark in marks)
{
    Console.WriteLine(mark);
}

// Method 3:
int[] scores = new int[] { 25, 45, 69, 78, 42 };

Console.WriteLine("The scores of the player are as follows: ");

foreach(int score in scores)
{
    Console.WriteLine(score);
}


Console.ReadLine();

