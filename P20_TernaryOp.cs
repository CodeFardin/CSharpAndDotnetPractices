// Ternary operator is a shorthand way of writing an if-else statement.

using System;
public class TernaryOp
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 5;

    int result = 9 > 8 ? 9 : 8;
    Console.WriteLine($"9 > 8 ? 9 : 8 = {result}");
    result = a > b ? a : b;
    Console.WriteLine($"a > b ? a : b = {result}"); 
    }
}
