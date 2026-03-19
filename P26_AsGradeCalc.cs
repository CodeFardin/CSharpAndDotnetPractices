using System;
public class GradeCalc
{
 public static void Main(string[] args)
    {
        // grade calculation
        // 90-100 - A
        // 80-89 - B
        // 70-79 - C
        // 60-69 - D
        // <60 - F

        Console.WriteLine("Enter Your Marks : ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 90 && marks <= 100)
        {
            Console.WriteLine("Your Grade is A");
        }
        else if (marks >= 80 && marks <= 89)
        {
            Console.WriteLine("Your Grade is B");
        }
        else if (marks >= 70 && marks <= 79)
        {
            Console.WriteLine("Your Grade is C");
        }
        else if (marks >= 60 && marks <= 69)
        {
            Console.WriteLine("Your Grade is D");
        }
        else
        {
            Console.WriteLine("Your Grade is F");
        }
    }   
}