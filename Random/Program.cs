Random randomNum = new Random();
string symbol = "=";
int num;
for(int i = 0; i < 10; i++)
{
    num = randomNum.Next(0, 150);
    Console.Write(i + "|");
    for(int j = 0; j < num; j++)
    {
        Console.Write("=");
    }
    Console.WriteLine();
}

Console.ReadLine();