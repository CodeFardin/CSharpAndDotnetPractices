public class Myclass
{
    public static void Main(string[] args)
    {
        //In here we are taking a number as double and then converting it to int
        double num1 = 3.14;
        int num2 = (int)num1; //explicit conversion
        Console.WriteLine("The value of num1 is: " + num1);
        Console.WriteLine("The value of num2 is: " + num2);
        //We can also convert using the Convert class
        double num3 = 3.14;
        int num4 = Convert.ToInt32(num3); //using Convert class for conversion
        Console.WriteLine("The value of num3 is: " + num3);     
        Console.WriteLine("The value of num4 is: " + num4);
        //we will use parse method to convert string to int
        string str = "123";
        int num5 = int.Parse(str); //using Parse method for conversion
        Console.WriteLine("The value of str is: " + str);   
        Console.WriteLine("The value of num5 is: " + num5);
        // I can also use TryParse method to convert string to int
        string input = "10";
        int result;
        bool isSuccess = int.TryParse(input, out result);
        Console.WriteLine($"number2 = {result}");
        //read key to prevent the console from closing immediately
        Console.ReadKey();
        //TryParse er subidha jodi amra 10.5 o dei taholeo program crash korbe na, karon TryParse method ta input ke int e convert korte parbe na, 
        // tai isSuccess variable er value false hobe, ebong result variable er value 0 hobe. Ekhane amra input hishebe "10" diyechi, tai isSuccess variable er value true hobe, ebong result variable er value 10 hobe.
    }
}