class Person
{
    public int age;
    public string name;

    public Person()
    {
        Console.WriteLine("This is a default constructor");
    }

    public Person(string n, int a)
    {
        name = n;
        age = a;
        Console.WriteLine($"Name: {n} Age: {a}");


    }
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        Person p2 = new Person("Fardin", 24);
    }
}