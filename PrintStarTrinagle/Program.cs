﻿string output = "";

for(int i = 0; i <= 5; i++)
{
    for(int j = 0; j < i; j++)
    {
        output += "*";
    }
    output += "\n";
}

Console.WriteLine(output);
Console.ReadLine();