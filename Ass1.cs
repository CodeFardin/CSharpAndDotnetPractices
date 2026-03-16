using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
public class Ass1
{
    public static void Main(string[] args)
    {
    string? studentName;
    int studentAge;
    
     double gpa;
     bool isRegistered;



    Console.Write("Enter your name: ");
    studentName = Console.ReadLine();

    Console.Write("Enter your age: ");
    studentAge = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter your GPA: ");
    gpa = Convert.ToDouble(Console.ReadLine());

    Console.Write("Have you Registered: ");
    isRegistered = Convert.ToBoolean(Console.ReadLine());

    
    Console.WriteLine("GPA: " + gpa);
    Console.WriteLine("Registered: " + isRegistered);

    Console.WriteLine("Name: " + studentName);
    Console.WriteLine("Age: " + studentAge + " years old");

    }

}