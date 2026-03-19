using System;

public class ConditionalSt
{
    public static void Main(string[] args)
    {
        int number = 1;
        //Syntax Of If Statement
        if ( number > 0 ) {
        Console.WriteLine("The Number Is Positive");
        }

        else if ( number == 0 )
        {
            Console.WriteLine("The Number Is Zero");

        }

        else if ( number < 0 )
        {
            Console.WriteLine("The Number Is Negative");
        }
        else
        {
            Console.WriteLine("Invalid Number");
        }
    }
}