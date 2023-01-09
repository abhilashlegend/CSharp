using System.Collections;

namespace HashtableExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Student[] students = new Student[5];
                students[0] = new Student(1, "Abhilash N", 87.00);
                students[1] = new Student(2, "Abhishek K", 88.00);
                students[2] = new Student(3, "Anup K", 99.00);
                students[3] = new Student(4, "Abhijeet", 66.00);
                students[4] = new Student(5, "Akhil D", 90.00);

                Hashtable studentTable = new Hashtable();

                foreach (var student in students)
                {
                    if (studentTable.ContainsKey(student.Id))
                    {
                        throw new Exception("Student with the same ID already exists");
                    }
                    else
                    {
                        studentTable.Add(student.Id, student);
                    }

                }

                foreach (Student stud in studentTable.Values)
                {
                    Console.WriteLine("Student ID: {0}", stud.Id);
                    Console.WriteLine("Student Name: {0}", stud.Name);
                    Console.WriteLine("Student Percentage: {0}", stud.Percentage);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public Student(int Id, string Name, double Percentage)
        {
            this.Id = Id;
            this.Name = Name;
            this.Percentage = Percentage;
        }
    }
}