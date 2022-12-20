Console.WriteLine("Please enter a string");
string input = Console.ReadLine();
Console.WriteLine("Please enter a character to search");
char c = Console.ReadKey().KeyChar;
int index = input.IndexOf(c);
Console.WriteLine($"\n index of char is at {index}");

Console.WriteLine("Please enter your first name");
string firstName = Console.ReadLine();
Console.WriteLine("Please enter your last name");
string lastName = Console.ReadLine();
string fullname = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullname}");


