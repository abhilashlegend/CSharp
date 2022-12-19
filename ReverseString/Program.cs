Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Please enter a string");
Console.ForegroundColor = ConsoleColor.Yellow;
string input = Console.ReadLine().ToString();

string reverse = "";

for(int i = input.Length - 1; i >= 0; i--)
{
    reverse += input[i];
}

Console.WriteLine(reverse);
Console.ReadLine();
