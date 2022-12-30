class Person
{
    private string firstName;
    private string lastName;
    private int age = 0;
    private string eyeColor = null;

    public Person()
    {
        Console.WriteLine("Welcome everyone.");
    }

    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public Person(string firstName, string lastName, int age, string eyeColor)
    {
        this.firstName = firstName;
        this.lastName = lastName;   
        this.age = age;
        this.eyeColor = eyeColor;
    }


    public void introduce()
    {
        if(this.age == 0 && this.eyeColor == null)
        {
            Console.WriteLine($"Hi, this is {firstName} {lastName}");
        }
        else
        {
            Console.WriteLine($"Hi, this is {firstName} {lastName} and I'm {age} years old. My eye color is {eyeColor}");
        }
        
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        Person ab = new Person("Abhilash", "N", 34, "brown");
        ab.introduce();

        Person rj = new Person("Rajkishor", "kattimani", 34, "brown");
        rj.introduce();

        Person rk = new Person("Rohit", "Kamath");
        rk.introduce();

        Console.ReadLine();
    }
}