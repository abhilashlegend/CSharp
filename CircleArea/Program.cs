const double pi = 3.142;

Console.WriteLine("Enter radius of the circle");
double radius = Double.Parse(Console.ReadLine());

double area = pi * radius * radius;
Console.WriteLine("Area of the circle is {0}", area);