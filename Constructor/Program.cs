class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private string eyeColor;

    public Person(string firstName, string lastName, int age, string eyeColor)
    {
        this.firstName = firstName;
        this.lastName = lastName;   
        this.age = age;
        this.eyeColor = eyeColor;
    }

    public void introduce()
    {
        Console.WriteLine($"Hi, this is {firstName} {lastName} and I'm {age} years old. My eye color is {eyeColor}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Person ab = new Person("Abhilash", "N", 34, "brown");
        ab.introduce();

        Person rj = new Person("Rajkishor", "kattimani", 34, "brown");
        rj.introduce();

        Console.ReadLine();
    }
}