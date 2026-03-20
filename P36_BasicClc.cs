using System;

class BasicClc
{
    public static void Main(String[] args)
    {
        int number1, number2;
        char operation;

        Console.Write("Enter an operation (+, -, *, /, %): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("Enter number 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());

        string res = operation switch
        {
            '+' => $"{number1} + {number2} = {number1 + number2}",
            '-' => $"{number1} - {number2} = {number1 - number2}",
            '*' => $"{number1} * {number2} = {number1 * number2}",
            '/' => $"{number1} / {number2} = {number1 / number2}",
            '%' => $"{number1} % {number2} = {number1 % number2}",
            _ => "Invalid operation"
        };

        Console.WriteLine(res);
    }
}