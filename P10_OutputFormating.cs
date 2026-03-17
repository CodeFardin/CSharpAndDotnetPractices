using System;

public class OutputFormating
{
    public static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 20;

        int result = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {result}");

        result = number1 - number2;
        Console.WriteLine($"{number1} - {number2} = {result}");

        result = number1 * number2;
        Console.WriteLine($"{number1} * {number2} = {result}");

        result = number1 / number2;
        Console.WriteLine($"{number1} / {number2} = {result}");

        result = number1 % number2;
        Console.WriteLine($"{number1} % {number2} = {result}");

        double divi = (double) number1 / number2;
        Console.WriteLine($"{number1} / {number2} = {divi.ToString("F4")}");
        }
}