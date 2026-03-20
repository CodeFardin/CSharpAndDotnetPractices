using System;

class Test
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter Started");
        Console.WriteLine("Choose 1. Farenheit to Celsisus");
        Console.WriteLine("Choose 2. Celsisus to Fahrenheit");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1: 
            Console.Write("Enter Farenheit temperature: ");
            double farenheit = Convert.ToDouble(Console.ReadLine());
            double celsisus = farenheit - 32 / 1.8;
            Console.WriteLine($"The temperature in Celsisus {celsisus:F2} ");
            break;
            case 2:
            Console.Write("Enter Celsius Temperature: ");
            double cels = Convert.ToDouble(Console.ReadLine());
            double farh = cels *1.8 + 32;
            Console.WriteLine($"The temperature in Farenheit {farh:F2} ");
            break;

            default : 
            Console.WriteLine("Invalid Choice");
            break;
        }
    }
}