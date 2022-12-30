public class Person
{
    public string firstName;
    public string lastName;

    public void introduce()
    {
        Console.WriteLine($"Hi, I am {firstName} {lastName}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person ab = new Person();
        ab.firstName = "Abhilash";
        ab.lastName = "N";
        ab.introduce();

        Person raj = new Person();
        raj.firstName = "RajKishor";
        raj.lastName = "Kattimani";
        raj.introduce();

        Console.ReadLine();

    }
}