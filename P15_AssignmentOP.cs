// Assignment Operators are =, +=, -=, *=, /=, %=
using System;
class Program
{
    static void Main(String[] args)
    {
        int a = 10;
        int b = 5;

        a += 5; // a = a + 5
        Console.WriteLine($"{a}");

        a -= 5; // a = a - 5
        Console.WriteLine($"{a}");

        a *= 5; // a = a * 5
        Console.WriteLine($"{a}"); 

        a /= 5; // a = a / 5
        Console.WriteLine($"{a}");         
    }
}