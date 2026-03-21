using System.Globalization;

class Multi
{
    public static void Main(string[] args)
    {
        int num, end;
        Console.WriteLine("Enter Any Start Number: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Any Ending Number: ");
        end = Convert.ToInt32(Console.ReadLine());

        for (int j = num; j <= end; j++)
        {
            for ( int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{j} X {i} = {j*i}");
        }
        }

        
    }
}