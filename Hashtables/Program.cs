using System.Collections;

namespace Hashtables;

class Program
{
    public static void Main(string[] args)
    {
        Student stud1 = new Student() { Id = 1, Name = "Abhilash", Percentage = 93.33 };
        Student stud2 = new Student() { Id = 2, Name = "Abhishek", Percentage = 99.00 };
        Student stud3 = new Student() { Id = 3, Name = "Chetan", Percentage = 50.00 };
        Student stud4 = new Student() { Id = 4, Name = "Anusha", Percentage = 63.00 };
        Student stud5 = new Student() { Id = 5, Name = "Chaitra", Percentage = 77.00 };

        Hashtable studentsTable = new Hashtable();
        studentsTable.Add(stud1.Id, stud1);
        studentsTable.Add(stud2.Id, stud2);
        studentsTable.Add(stud3.Id, stud3);
        studentsTable.Add(stud4.Id, stud4);
        studentsTable.Add(stud5.Id, stud5);

        // Retrieve individual item with know ID
        Student storedStudent = (Student)studentsTable[stud1.Id];
        Console.WriteLine("Student ID: {0}, Name: {1}, Percentage: {2}", storedStudent.Id, storedStudent.Name, storedStudent.Percentage);
        
        // Retrieve all values from a hashtable
        foreach(DictionaryEntry entry in studentsTable)
        {

            Student temp = (Student)entry.Value;
            Console.WriteLine("Student ID: {0}", temp.Id);
            Console.WriteLine("Student Name: {0}", temp.Name);
            Console.WriteLine("Student Percentage: {0}", temp.Percentage);
        }

        Console.WriteLine("---------------------------------------------------------");

        foreach(Student value in studentsTable.Values)
        {
            Console.WriteLine("Student ID: {0}", value.Id);
            Console.WriteLine("Student Name: {0}", value.Name);
            Console.WriteLine("Student Percentage: {0}", value.Percentage);
        }

        Console.ReadLine();

    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Percentage { get; set; }  
}
