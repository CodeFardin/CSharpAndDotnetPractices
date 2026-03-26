using System.Security.Cryptography.X509Certificates;

public class Person
{
    public int a;
    public int b;
}
class Test
{
    public static void Main(string[] args)
    {
         int x = 30;
    int y = x;
    y = 10;
    Console.WriteLine(x);
    Console.WriteLine(y);
    
    Person p1 = new Person();
    
    p1.a = 202;
    p1.b = 102;
    Console.WriteLine($"The value of a: {p1.a}\nThe value of b: {p1.b}");
    
    Person p2 = p1;
    p2.a = 1;
    p2.b = 3;
    Console.WriteLine($"The value of a p2: {p2.a}\nThe value of b p2: {p2.b}");
    Console.WriteLine($"The value of a p1: {p1.a}\nThe value of b p1: {p1.b}");

    

        
    }
   
}