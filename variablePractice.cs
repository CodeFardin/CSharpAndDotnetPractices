using System;

class First
{
    public static void Main(string[] args)
    {
        // String type
        string fname = "Fardin";
        string lname = "Hasan";

        // Integer type
        int age = 22;

        // Double type
        double cgpa = 3.80;

        // Boolean type
        bool isPassed = true;

        // Character type
        char grade = 'A';

        // Output logic fix
        Console.writeLine("My name is: " + fname + " " + lname);
        Console.writeLine("I am " + age + " years old.");
        Console.writeLine("My CGPA is: " + cgpa);
        Console.writeLine("I passed this semester: " + isPassed);
        Console.writeLine("My Grade is: " + grade);
    }
}