
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

ParamsFunction("This", "is", "a", "test", "message");

int price = 50;
float pi = 3.142f;
char at = '@';
string book = "The Hobbit";

ParamsMethod(price, pi, at, book);
Console.ReadLine();