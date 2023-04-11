using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManager
{
    public class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            // Let's add some universities
            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "KUD" });

            // Let's add some students
            students.Add(new Student
            {
                Id = 1,
                Name = "Abhilash N",
                Age = 20,
                Gender = "male",
                UniversityId = 1
            });

            students.Add(new Student
            {
                Id = 2,
                Name = "ANup Kamath",
                Age = 20,
                Gender = "male",
                UniversityId = 2
            });

            students.Add(new Student
            {
                Id = 3,
                Name = "Abhishek Kulkarni",
                Age = 20,
                Gender = "male",
                UniversityId = 1
            });

            students.Add(new Student { Id = 4, Name = "Abhijeeth Suhani", Age = 20, Gender = "male", UniversityId = 1 });

            students.Add(new Student { Id = 5, Name = "Akhil Desai", Age = 20, Gender = "male", UniversityId = 2 });

            students.Add(new Student { Id = 6, Name = "Akshata K", Age = 19, Gender = "female", UniversityId = 1 });

            students.Add(new Student { Id = 7, Name = "Anusha Ingalle", Age = 20, Gender = "female", UniversityId = 1 });

            students.Add(new Student { Id = 8, Name = "Aruna Kulkarni", Age = 20, Gender = "female", UniversityId = 2 });

            students.Add(new Student { Id = 9, Name = "Amesha Patel", Age = 17, Gender = "female", UniversityId = 1 });

            students.Add(new Student { Id = 10, Name = "Arjun Kapoor", Age = 24, Gender = "male", UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - students: ");
                
            foreach(Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - students: ");

            foreach(Student student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentsByAge()
        {
            IEnumerable<Student> sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Sorted Students By Age: ");
            foreach(Student student in sortedStudents)
            {
                student.Print();
            }
        }

        public void GetStudentsFromYale()
        {
            IEnumerable<Student> yaleStudents = from student in students join university in universities on student.UniversityId equals university.Id where university.Name == "Yale" select student;

            Console.WriteLine("Students of Yale University");
            foreach(Student student in yaleStudents)
            {
                student.Print();
            }
        }

        public void GetStudentsFromKUD()
        {
            IEnumerable<Student> kudStudents = from student in students join university in universities on student.UniversityId equals university.Id where university.Name == "KUD" select student;

            Console.WriteLine("Students of KUD University");
            foreach(Student student in kudStudents)
            {
                student.Print();
            }

        }

    }
}
