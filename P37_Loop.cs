using System;

class Loop
{
    public static void Main()
    {
        //for, while, do while

        Console.WriteLine("Enter the Last Number");
        // for Loop (initializer, condition, update)
        int lastTerm = Convert.ToInt32(Console.ReadLine());


        for(int count = 1; count <= lastTerm; count++)
        {
            Console.WriteLine($"Bangladesh {count}");

        }
        
        for(int count = 2; count <= lastTerm; count = count+2)
        {
            if (count % 2 == 0)
            {
            Console.WriteLine($"The even numbers {count}");
            } 

        }
        Console.Write("Enter the Starting Number: ");
        int start = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Ending Number: ");
        int end = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Difference: ");
        int diff = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Starting from: ", start);

        for(int count = start; count <= end; count = count + diff)
        {
            Console.Write($"{count} ");
        }


    }
}