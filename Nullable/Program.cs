int? age = null;
if (age != null)
{
    global::System.Console.WriteLine("The age is {0}", age);
}
else
{
    global::System.Console.WriteLine("No age given");
}

/* Null Collacing example */
int? a = null;

int b = 4;

int c = a ?? b;

Console.WriteLine("The value of c is {0}", c);


Console.ReadLine();