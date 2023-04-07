using System.Reflection.Metadata.Ecma335;

int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

oddNumbers(numbers);

evenNumbers(numbers);

Console.ReadLine();

void oddNumbers(int[] numbers) {
    Console.WriteLine("Odd Numbers: ");

    IEnumerable<int> oddNumbers = from number in numbers where number % 2 != 0 select number;

    foreach(int i in oddNumbers)
    {
        Console.WriteLine(i);
    }
}

void evenNumbers(int[] numbers)
{
    Console.WriteLine("Even numbers");

    IEnumerable<int> evenNumbers = from number in numbers where number % 2 == 0 select number;

    foreach(int i in evenNumbers)
    {
        Console.WriteLine(i);
    }
}
