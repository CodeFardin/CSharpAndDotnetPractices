using System;

public class FindSmallNumber
{
 public static void Main(string[] args)
    {
        // choose small number from 3 numbers

        Console.WriteLine("Enter First Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Third Number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2 && num1 < num3)
        {
            Console.WriteLine("Number 1 is the smallest number");
        }
        else if (num2 < num1 && num2 < num3)
        {
            Console.WriteLine("Number 2 is the smallest number");
        }
        else
        {
            Console.WriteLine("Number 3 is the smallest number");
        }

    }   
}