using System.ComponentModel;
using System.Globalization;

class UserDefM
{
    public static void Add(int number1,int number2)
    {   
        int result = number1+number2;
        Console.WriteLine($"{number1} + {number2} = {result}");
    }
    public static void Sub(int number1,int number2)
    {
         int result = number1-number2;
        Console.WriteLine($"{number1} - {number2} = {number1-number2}");
    }
    public static int Square(int number1)
    {
        return number1*number1;
    }
   public static void Main(string[] args)
    {


        Add(10,20);
        Sub(20,10);
        int r = Square(4);
        Console.WriteLine($"4's square is {r}");


        /*int number1, number2;
        number1 = 20;
        number2 = 30;

        int result = number1 + number2;

        Console.WriteLine($"{number1} + {number2} = {number1+number2}");

        number1 = 10;
        number2 = 20;

         result = number1 + number2;

        Console.WriteLine($"{number1} + {number2} = {number1+number2}");

        number1 = 30;
        number2 = 10;

         result = number1 - number2;

        Console.WriteLine($"{number1} - {number2} = {number1-number2}");
        */

        Console.Read();

        
    }
}