// >, <, >=, <=, ==, !=
using System;
public class RelationalOp
{
    public static void Main(string[] args)
    {
        int a = 1;
        int b = 2;

        //Comparison Operators
        Console.WriteLine($"a > b: {a > b}"); // false
        Console.WriteLine($"a < b: {a < b}");
        Console.WriteLine($"a >= b: {a >= b}");
        Console.WriteLine($"a <= b: {a <= b}");
        Console.WriteLine($"a == b: {a == b}");
        Console.WriteLine($"a != b: {a != b}");

}}