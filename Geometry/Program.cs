﻿namespace Geometry;

class Program
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Width = 100;
        rectangle.Height = 250;
        rectangle.Length = 175;
        Console.WriteLine("Volume of Rectangle = " + rectangle.getVolume());
        Console.ReadLine();
    }
}