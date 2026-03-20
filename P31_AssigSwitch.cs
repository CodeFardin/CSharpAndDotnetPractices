//Taking a day from user 
//Check if it is weekday or not
//Handle the case

using System;
using System.ComponentModel;

public class AssigSwitch
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a day of the week: ");
        string day = (Console.ReadLine());
        day = day.ToLower();

        switch (day)
        {
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
            case "friday":
                Console.WriteLine($"{day} is a weekday.");
                break;
            case "saturday":
            case "sunday":
            Console.WriteLine($"{day} is a weekend/");
            break;
            dafault:
            Console.WriteLine("Invalid day entered");
            break;
        }

    }
}