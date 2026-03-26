class Person
{
    private string name;
    private int age;

    public string Name 
    {
        get;
        set;
    }
    public int Age
    {
        get;
        set;
}
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.Name = "Fardin";
        p1.Age = 17;
        Console.WriteLine($"Name: {p1.Name}, Age: {p1.Age}"); 

    }}
