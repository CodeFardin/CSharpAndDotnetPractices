public class CelFerConv
{
    public static void Main(string[] args)
    {
        //The rules: C = (F - 32) * 5 / 9 and F = C * 9 / 5 + 32
        Console.WriteLine("Temperature Converter");
        Double celcius, farenheit;
        Console.WriteLine("Choose the temperature you want to convert: \n 1. Celcius\n 2. Farenheit");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("Enter the temp in Farenheit: ");
            farenheit = Convert.ToDouble(Console.ReadLine());
            celcius = (farenheit - 32) * 5 / 9;
            Console.WriteLine($"Temperature in Celcius is = {celcius.ToString("F2")}");
        }
        else if(choice == 2)
        {
        Console.Write("Enter the temperature in Celcius: ");
        celcius = Convert.ToDouble(Console.ReadLine());
        farenheit = celcius * 9 / 5 + 32;
        Console.WriteLine($"Temperature in Farenheit is = {farenheit.ToString("F3")}");;
    } }
        
}