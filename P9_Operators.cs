using System;
public class Operators
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        int sum = a + b;
        Console.WriteLine("Addition: " + sum);

        int div = a - b;
        Console.WriteLine("Substraction: " + div);
        
        int mul = a * b;
        Console.WriteLine("Multiplication: " + mul);

        int remainder = a % b;
        Console.WriteLine("Remainder: " + remainder);

        int c = 10;
        int d = 21;
        int result = c + d;
        Console.WriteLine("Addition: " + result);

        result = c - d;
        Console.WriteLine("Substraction: " + result);
        
        result = c * d;
        Console.WriteLine("Multiplication: " + result);

        result = c % d;
        Console.WriteLine("Remainder: " + result);

        double divi = (double)c / d;
        Console.WriteLine("Division: " + div.ToString("F3"));
        //ekhane F3 mane holo 3 decimal place porjonto show korbe. F2 dile 2 decimal place porjonto show korbe. F0 dile kono decimal place show korbe na.  
        
        

    }
}