namespace EnumExample
{
    enum weeks { Mon = 1, Tue, Wed, Thu, Fri, Sat, Sun };
    class Program
    {
        public static void Main(string[] args)
        {
            DateOnly  dt = new DateOnly();
            Console.WriteLine((int)weeks.Mon == dt.Day);
            DateTime today = DateTime.Now;
            Console.WriteLine((weeks)(int)today.DayOfWeek);

          
            Console.ReadLine();
        }
    }
}