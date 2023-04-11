using System.Xml.Linq;

namespace LinqWithXML
{
    class Program
    {
        static void Main(string[] args)
        {
            // We simply apply our student structure to XML

            string StudentXML = @"<Students>
                                    <Student>
                                        <Name>Tony Stark</Name>
                                        <Age>21</Age>
                                        <University>Yale</University>
                                        <Branch>Computer Science</Branch>
                                    </Student>
                                    <Student>
                                        <Name>Mark Zukerburg</Name>
                                        <Age>23</Age>
                                        <University>Yale</University>
                                        <Branch>Civil</Branch>
                                    </Student>
                                    <Student>
                                        <Name>Leyla Ford</Name>
                                        <Age>23</Age>
                                        <University>Stanford</University>
                                        <Branch>Electrical</Branch>
                                    </Student>
                                </Students>
                                ";

            XDocument studentsXDoc = new XDocument();
            studentsXDoc = XDocument.Parse(StudentXML);

            var students = from student in studentsXDoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Branch = student.Element("Branch").Value
                           };

            foreach(var student in students)
            {
                Console.WriteLine("Student {0} with age {1}, {2} branch from university {3}", student.Name, student.Age, student.Branch, student.University);
            }
        }
    }
}