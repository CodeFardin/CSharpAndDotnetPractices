using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Person
{
    public string name;
    public int age;

    public void EnterInfo(string n, int m)
    {
        name = n;
        age = m;

    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}\n Age: {age}");
    }
    
}

class MainClass
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.EnterInfo("Fardin",24);
        p1.Display();
        Console.Read();

    }
}