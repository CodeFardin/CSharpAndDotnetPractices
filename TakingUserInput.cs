//we use console.readline() method to take user input from the console. This method returns a string, so we need to convert it to the desired data type if we want to use it as a number or other type.
using System;
public class TakingUserInput
{
    public static void Main(string[] args)
    {   Console.WriteLine("Enter the name of the student: ");
        //string? muloto nullable string, karon Console.ReadLine() method null return korte pare jodi user kichu input na kore enter press kore. 
        // Ekhane amra studentName variable e user er input store korbo, ebong tarpor seta print korbo.
        string? studentName = Console.ReadLine(); //taking user input as string
        Console.WriteLine("The name of the student is: " + studentName);
        Console.WriteLine("Enter the age of the student: ");
        //Ekhane amra age variable e user er input store korbo, ebong
        //tarpor seta print korbo. Age variable er data type int, tai amra user er input ke int e convert korte hobe using Convert.ToInt32() method.
        int age = Convert.ToInt32(Console.ReadLine()); //taking user input as int
        Console.WriteLine("The age of the student is " + age);
        Console.WriteLine("Enter the grade of the student: ");
        //Ekhane amra grade variable e user er input store korbo, ebong tarpor seta print korbo. Grade variable er data type char, tai amra user er input ke char e convert korte hobe using Convert.ToChar() method.
        char grade = Convert.ToChar(Console.ReadLine()); //taking user input as char
        Console.WriteLine("The grade of the student is " + grade);
        Console.WriteLine("Enter the height of the student: ");
        //Ekhane amra height variable e user er input store korbo, ebong
        //tarpor seta print korbo. Height variable er data type double, tai amra user er input ke double e convert korte hobe using Convert.ToDouble() method.
        double height = Convert.ToDouble(Console.ReadLine()); //taking user input as double
        Console.WriteLine("The height of the student is " + height);
        //read key to prevent the console from closing immediately
        Console.ReadKey();
        //Ekhane amra user er input ke different data type e convert kore print korchi. Jodi user kichu input na kore enter press kore, tahole Console.ReadLine() method null return korbe, ebong Convert.ToInt32(), Convert.ToChar(), Convert.ToDouble() methods null value ke convert korte parbe na, tai program crash korbe. Tai amra user er input ke nullable type e declare korechi, jate program crash na kore, ebong user er input ke safely handle korte pari.
    }
}