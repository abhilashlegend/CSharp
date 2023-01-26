using System.Globalization;

namespace IEnumeratorAndIEnumerable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach(Dog dog in shelter)
            {
                if (!dog.IsNaughty)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }

            Console.ReadLine();
        }
    }
}