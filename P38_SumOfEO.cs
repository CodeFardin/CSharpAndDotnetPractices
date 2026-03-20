public class SumOfEO
{
    public static void Main()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (i%2 == 0)
            {
                sum = sum + i;
            }
        }
        Console.WriteLine($"Sum  = {Sum}");
    }
}