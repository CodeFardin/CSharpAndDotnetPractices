using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class First
{
    public static void Main (String[] args)
    {
        //String
        string Fname;
        Fname = "Fardin";
        string Lname = "Hasan";
        // integer type
        int age = 22;
        // double type
        double cgpa = 3.80;
        //boolean type
        bool isPassed = true;
        //character type
        char grade = 'A';
        Console.Writeline("My name is:", Fname+" "+Lname);
        Console.Writeline("I am "+age+"Years old");
        Console.Writeline("My CGPA is ",cgpa);
        Console.Writeline("I Passed this semester",isPassed);

    }
}