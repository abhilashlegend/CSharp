
Console.WriteLine("Enter the number to print table");
try
{
    int num = int.Parse(Console.ReadLine());
    if (num != null)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} = {num * i}");
        }
    }
} catch(System.FormatException)
{
    Console.WriteLine("Please enter a number next time");
}

Console.ReadLine();