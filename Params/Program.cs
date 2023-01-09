
void ParamsFunction(params string[] Params)
{
    for(int i = 0; i < Params.Length; i++)
    {
        Console.WriteLine("{0}", Params[i]);
    }
}

void ParamsMethod(params object[] stuff)
{
    // for each loop go through  the array of objects
    foreach(object obj in stuff)
    {
        // Print each object followed by space
        Console.WriteLine(obj + " ");
    }
}

int FindMinValue(params int[] numbers)
{
    int min = int.MaxValue;

    foreach(int number in numbers)
    {
        if(number < min) min = number;
    }
    return min;
}

ParamsFunction("This", "is", "a", "test", "message");

int price = 50;
float pi = 3.142f;
char at = '@';
string book = "The Hobbit";

ParamsMethod(price, pi, at, book);

int min = FindMinValue(59, 78, 6, 45, 9, 658, 42);
Console.WriteLine("The minimum value from the given numbers is {0}", min);

Console.ReadLine();