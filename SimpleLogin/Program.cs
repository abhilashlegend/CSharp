string username;
string password;

void Register()
{
    Console.WriteLine("Please enter your username");
    username = Console.ReadLine();
    Console.WriteLine("Please enter your password");
    password = Console.ReadLine();
    Console.WriteLine("Registeration completed. Thank you.");
    Console.WriteLine("---------------------------------------------");
}

void Login()
{
    Console.WriteLine("Please enter your username");
    string uname = Console.ReadLine();
    Console.WriteLine("Please enter your password");
    string pwd = Console.ReadLine();
    if(username == uname && password == pwd)
    {
        Console.WriteLine("Login Successfull");
    } 
    else
    {
        Console.WriteLine("Invalid Login details, please try again");
    }
}

Register();
Login();
Console.ReadLine();


