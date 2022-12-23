Console.WriteLine("Please enter a number to see if it is divisible by 3 or 7");
string num = Console.ReadLine();
int n;
bool flg = int.TryParse(num, out n);

if (flg)
{
    if(n % 3 == 0)
    {
        Console.WriteLine("Number is Divisible by 3");
    } 
    else if(n % 7 == 0)
    {
        Console.WriteLine("Number is Divisible by 7");
    }
    else
    {
        if (n % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}

Console.ReadLine();