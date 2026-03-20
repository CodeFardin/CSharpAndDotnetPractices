public class SwitchObk
{
    public static void Main(string[] args)
    {
    /* object number = "4";
    switch (number)
    {
        case int:
        Console.WriteLine($"Integer {number}");
        break;
        case double:
        Console.WriteLine("Double");
        break;
        case string:
        Console.WriteLine("String");
        break;

        default:
        Console.WriteLine("Unknown Type");
        break;
    }*/
    object num2 = 8;
    string result = num2 switch
    {
        int => $"Integer {num2}",
        double => $"Double{num2}",
        string => $"String {num2}",
        _ => "Unknown Type",

    };
    Console.WriteLine(result);
    Console.ReadKey();
}
}