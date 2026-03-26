class Person
{
    public string name;

    private int age;

    public void setAge(int a)
    {
        age = a;
    }
    public int getAge()
    {
        return age;
    }


    public void DisplayInfo()
    {
    Console.WriteLine($"Name: {name}, Age: {age}\n");
    }

}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person();

        p1.name = "Fardin";
        p1.setAge(33); 
    

        Console.WriteLine($"Name: {p1.name}, Age: {p1.getAge()}");
        Console.Read();

    
    }

}