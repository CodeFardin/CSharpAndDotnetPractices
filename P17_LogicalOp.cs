// Logical Operators: &&, ||, !
using System;

public class LogicalOp
{
    public static void Main(string[] args)
    {
       Console.WriteLine(8>5 && 8<9 && 8==8);
       Console.WriteLine(8>5 && 7<2);

       Console.WriteLine(8>5 || 7<2);
       Console.WriteLine(8>5 || 7<2 || 9==9);

       Console.WriteLine(!(8<5));
       Console.WriteLine(!(7>6 && 5>4 && 6<9));
       
    }
}
