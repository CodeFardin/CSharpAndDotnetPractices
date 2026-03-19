using System;
public class LeapYr
{
  public static void Main(string[] args)
    {
        //Leap Year - 2020, 2024, 2028
        //Not Leap year - 2021, 2022, 2023
        Console.WriteLine("Enter Any Year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if ( year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
        {
            Console.WriteLine("LeapYear");
        }
      else{
        Console.WriteLine("Not Leap Year");
    }
    }
}
