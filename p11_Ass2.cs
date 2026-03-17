// Assignment 2: Output Formating
//sum and average of 3 numbers
using System;
using System.ComponentModel;

public class Assignment2
{
    public static void Main(string[] args)
    {
       int num1, num2, num3, sum;
       double avg;

       Console.Write("Number1 = ");
       num1 = Convert.ToInt32(Console.ReadLine());

       Console.Write("Number2 = ");
       num2 = Convert.ToInt32(Console.ReadLine());

       Console.Write("Number3 = ");
       num3 = Convert.ToInt32(Console.ReadLine());
       
       sum = num1 + num2 + num3;
       Console.WriteLine($"sum = {sum}");

       avg = (double)sum / 3;
       Console.WriteLine($"average = {avg.ToString(("F4"))}");


    }
    }
