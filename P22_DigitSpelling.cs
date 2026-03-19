using System;

public class DigitSpelling
{
    public static void Main(string[] args)
    {
        // digit - 0-9
        // digit Spelling - zero, one, two, three, four, five, six, seven, eight, nine
        // if digit >9 then it will say invalid digit

        Console.WriteLine("Enter Any Digit (0-9) : ");

        int digit = Convert.ToInt32(Console.ReadLine());

     if ( digit == 0)
        {
            Console.WriteLine("Zero");

        }
      else if ( digit == 1)
        {
            Console.WriteLine("One");
        }
         else if ( digit == 2)
        {
            Console.WriteLine("Two");
        }
         else if ( digit == 3)
        {
            Console.WriteLine("Three");
        }
         else if ( digit == 4)
        {
            Console.WriteLine("Four");
        }
            else if ( digit == 5)
            {
                Console.WriteLine("Five");
            }
            else if ( digit == 6)
            {
                Console.WriteLine("Six");
            }
            else if ( digit == 7)
            {
                Console.WriteLine("Seven");
            }
            else if ( digit == 8)
            {
                Console.WriteLine("Eight");
            }
            else if ( digit == 9)
            {
                Console.WriteLine("Nine");
            }
            else
            {
                Console.WriteLine("Invalid Digit");
            }

    }
}