using System;
public class AsEvenOdd
{
    public static void Main(string[] args)
    {
        // even number - 0,2,4,6,8
        // odd number - 1,3,5,7,9

        Console.WriteLine("Enter Any Number : ");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("Even Number");
        }
        else
        {
            Console.WriteLine("Odd Number");
        }
    }
}