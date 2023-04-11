namespace UniversityManager
{
    class Program
    {
        public static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            um.FemaleStudents();
            Console.ReadLine();
        }
    }
}