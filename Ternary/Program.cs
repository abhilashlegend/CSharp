Console.WriteLine("Enter temperature");
string inpTemp = Console.ReadLine();
int temp;
bool isNum = int.TryParse(inpTemp, out temp);
string status;

if (isNum)
{
    status = temp < 15 ? "it\'s to cold here" : temp >= 16 && temp <= 28 ? "it is ok" : "It is hot here";
    Console.WriteLine(status);
} else
{
    Console.WriteLine("Not a valid temperature");
}

Console.ReadLine();