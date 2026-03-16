using System;

class Testing
{
    public static void Main(string[] args)
    {
        //constant variable
        const double pi = 3.14;
        Console.WriteLine("The value of pi is: " + pi);

        //static variable
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
        num1=num2=num3=10;
        Console.WriteLine("The values of num1, num2, and num3 are: " + num1 + ", " + num2 + ", " + num3);
    }
}