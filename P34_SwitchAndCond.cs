using System;
public class SwitchAndCond
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number between 1 to 10: ");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case int num when num%2 == 0: 
            Console.WriteLine("Even Number");
            break;
            case int num when num%2 != 0:
            Console.WriteLine("Odd Number");
            break;
            default:
            Console.WriteLine("Invalid Number");
            break;
        }
    }
}