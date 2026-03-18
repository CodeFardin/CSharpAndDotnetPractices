// Unary operators are +, -, ++, --, !, ~, and (type).
using System;
public class UnaryOp
{
    public static void Main(string[] args)
    {
        int number = 10;
        Console.WriteLine(++number); //11 // Pre-increment: increments number to 11, then returns 11
        Console.WriteLine(number++); //11
        Console.WriteLine(number); //12
 // Post-increment: returns 11, then increments number
}
}