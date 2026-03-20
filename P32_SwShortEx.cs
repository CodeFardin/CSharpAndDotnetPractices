using System;
using System.Linq.Expressions;
using System.Reflection.Metadata;
public class SwitchShortendExp
{
    public static void Main(string[] args)
    {
        int digit = 3;
       string message = digit switch
        {
            
        1 => "One",
        2 => "Two",
        3 => "Three",
        4 => "Four",
        5 => "Five",
        _ => "Invalid Digit"
        };
        Console.WriteLine($"Digit {digit} is {message}");
        /*Console.WriteLine("Enter a Number between 1 to 5: ");
        int number = Convert.ToInt32(Console.ReadLine());
*/
       /* switch (number)
    {
        case 1: Console.WriteLine("One"); break;
        case 2: Console.WriteLine("Two"); break;
        case 3: Console.WriteLine("Three"); break;
        case 4: Console.WriteLine("Four"); break;
        case 5: Console.WriteLine("Five"); break;
        default: Console.WriteLine("Invalid Digit"); break;
        
    }
    Console.ReadKey();  */
/*string result = variable switch
{
 pattern1 => expression1;
 pattern2 => expression2;
 pattern3 => expression3;
 _ => Expression;   
};*/
    }
}
