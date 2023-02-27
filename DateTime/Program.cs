
Console.WriteLine("Today's date time is {0}", DateTime.Today);
// Write time on screen
Console.WriteLine("Current time is {0}", DateTime.Now);

Console.WriteLine("Tomorrow will be {0}",  GetTomorrow());

Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek.ToString());

int days = DateTime.DaysInMonth(2023, 2);
Console.WriteLine("Days in Feb 2023 is {0}", days);

Console.WriteLine("Write your date of birt in this format: yyyy-mm-dd");
string input = Console.ReadLine();  

DateTime now = DateTime.Now;
DateTime datetime;
if(DateTime.TryParse(input, out datetime))
{
    Console.WriteLine(datetime);
    TimeSpan daysPassed = now.Subtract(datetime);
    Console.WriteLine("You are {0} days old", daysPassed.ToString());
} else
{
    Console.WriteLine("Wrong input");
}



static DateTime GetTomorrow()
{
    return DateTime.Today.AddDays(1);
}
Console.ReadLine();
