class NestedLoop
{
    public static void Main(string[] args)
    {
     int i;
     for (i = 1; i <= 50; i++)
        {
            
            if (i == 40)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}