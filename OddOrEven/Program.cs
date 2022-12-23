Console.WriteLine("Please enter a number");
string num = Console.ReadLine();
int val;
bool isNum = int.TryParse(num, out val);

if (isNum)
{
    if(val % 2 == 0)
    {
        Console.WriteLine("Entered number is even");
    }
    else
    {
        Console.WriteLine("Entered number is odd");
    }
} 
else
{
    Console.WriteLine("You have not entered number, try again.");
}
