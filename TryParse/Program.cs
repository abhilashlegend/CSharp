Console.WriteLine("Please enter your age");
int age;
bool flag =   int.TryParse(Console.ReadLine(), out age);

/* If user entered number */
if (flag)
{
    if(age > 18)
    {
        Console.WriteLine("You are eligible for voting");
    } else
    {
        Console.WriteLine("You are not eligible for voting");
    }

} 
else
{
    Console.WriteLine("Invalid entry, please try again");
}
