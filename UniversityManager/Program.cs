namespace UniversityManager
{
    class Program
    {
        public static void Main(string[] args)
        {
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            Console.WriteLine("\n");
            um.FemaleStudents();
            Console.WriteLine("\n");
            um.SortStudentsByAge();
            Console.WriteLine("\n");
            um.GetStudentsFromYale();
            Console.WriteLine("\n");
            um.GetStudentsFromKUD();
            Console.WriteLine("\n");

            int[] someInts = { 30, 12, 5, 87, 65, 45 };
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;

            foreach(int i in sortedInts)
            {
                Console.WriteLine(i);
            }

            //IEnumerable<int> reversedInts = sortedInts.Reverse();
            IEnumerable<int> reversedInts = from i in someInts orderby i descending select i;
            Console.WriteLine("\n");
            foreach(int i in reversedInts)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}