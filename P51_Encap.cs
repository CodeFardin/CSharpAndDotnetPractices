class Person
{
    public string name;
    private int age;


}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.name = "Fardin Hasan";
        p1.age = 33;
        Console.WriteLine($"name = {p1.name}m age= {p1.age}");
    }
}