class Person
{
    public string name;
    public int age;
    //creating a parameterwise construcrtor
    public Person(string n, int a)
    {


        name = n;
        age = a;
    
    } 
    
    //Creating a default constructor
    public Person()
    {


        name = "Test";
        age = 8;
    
    } 
    public void SetValue(string n, int a)
{
    name = n;
    age = a;
}
public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}\n");
    }
//Constructor howar shorto holo method er nam == class er nam
//normally return type thakbe na
//Object k initiallize korte help kore
//Ekta class e default, parameterwise constructor thaakte pare
}

class Test
{
    public static void Main(string[] args)
    {
        Person p1 = new Person("Fardin", 24);
        //Jokhon amra object create korbo tokhon automatically constructor call hoye jabe
        p1.DisplayInfo();

        Person p2 = new Person("Hasan",25);
        p2.DisplayInfo();

        Person p3 = new Person();
        p3.DisplayInfo();
    }
}