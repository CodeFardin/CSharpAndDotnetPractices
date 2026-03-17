//Triangle Area = 0.5 * base * height
using System;

public class AreaClc
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculating the area of a triangle");
        Console.Write("Base = ");

        double baselength =Convert.ToDouble(Console.ReadLine());
        Console.Write("Height= ");
        double height = Convert.ToDouble(Console.ReadLine());

        double triangleArea = 0.5 * baselength * height;
        Console.WriteLine($"Triangle Area = {triangleArea.ToString("F3")}");
    }
}