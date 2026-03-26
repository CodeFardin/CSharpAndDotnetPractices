class Person
{
    public readonly string name;

    public Person(string n)
    {
        name = n;
    }


}
class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Fardin constructo or");
        
        Console.WriteLine($"Name: {p1.name}");
    }
}