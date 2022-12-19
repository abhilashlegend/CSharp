int first = 0;
int second = 1;
int third = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(first);
    third = first + second;
    first = second;
    second = third;
    
        
}
Console.ReadLine();