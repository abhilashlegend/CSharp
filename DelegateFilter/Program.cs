namespace FilterDelegate
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public delegate bool PersonFilterDelegate(Person p);
    public class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person() { Name = "Abhilash", Age = 34 };
            Person p2 = new Person() { Name = "Akhil", Age = 23 };
            Person p3 = new Person() { Name = "Nikhil", Age = 25 };
            Person p4 = new Person() { Name = "Rohan", Age = 17 };
            Person p5 = new Person() { Name = "Vivek", Age = 13 };
            Person p6 = new Person() { Name = "Surekha", Age = 73 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4, p5, p6 };

            PersonFilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 20 && p.Age < 30;
            };

            DisplayPeople("Minor", people, isMinor);
            DisplayPeople("Adults", people, isAdult);
            DisplayPeople("People in twenties", people, filter);
            DisplayPeople("Sceniar", people, delegate (Person p)
            {
                return p.Age > 60;
            });

            Console.ReadLine();

           
        }

        public static void DisplayPeople(string title,List<Person> people, PersonFilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach(Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine("{0}, {1} years old", person.Name, person.Age);
                }
            }
        }

        public static bool isMinor(Person p )
        {
            return p.Age < 18;
        }

        public static bool isAdult(Person p)
        {
            return p.Age > 18;
        }
    }
}