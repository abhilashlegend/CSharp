string[] subjects = new string[] { "English", "Kannada", "Hindi", "Maths", "Science", "Social" };

int[] marks = new int[6];

Console.WriteLine("Enter the Marks");
for(int i = 0; i < subjects.Length; i++)
{
    Console.WriteLine("Enter marks for {0}", subjects[i]);
    marks[i] = int.Parse(Console.ReadLine());
}

int sum = 0;

foreach(int mark in marks)
{
    sum += mark;
}
Console.WriteLine("Total Marks = {0}", sum);
Console.ReadLine();