class Test
{
    public static void Main(String[] args)
    {
        //Circle Area = pi * radius * radius
        const double pi = 3.1416;

        Console.WriteLine("Calculating the area of a circle");
        Console.Write("Radius = ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double circleArea = pi * radius * radius;
        double circleArea2 = Math.PI * radius * radius;
        Console.WriteLine($"Circle Area = {circleArea.ToString("F2")}");
        Console.WriteLine($"Circle Area Using Math.PI = {circleArea2.ToString("F2")}");

    }
    
}