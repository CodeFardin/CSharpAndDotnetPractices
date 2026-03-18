// BitWise Operators are &, |, ^, ~, <<, >>
using System;
using System.Reflection;
public class BitwiseOp
{
    public static void Main(string[] args)
    {
        int num1 = 15; //Binary: 1111
        int num2 = 12; //Binary: 1100
        int result;    // Binary: 1100

        result = num1 & num2; //the result is 12 because the bits that are 1 in both numbers are 1100
        Console.WriteLine($"{num1} & {num2} = {result}");

        result = num1 | num2;
        Console.WriteLine($"{num1} | {num2} = {result}");
        //the result is 15 because the bits that are 1 in either number are 1111

        result = num1 ^ num2;
        Console.WriteLine($"{num1} ^ {num2} = {result}");
        //the result is 3 because the bits that are 1 in either number but not both are 0011

        result = ~num1;
        Console.WriteLine($"~{num1} = {result}");   

        result = num1 >> 2; //num1 = 1111 write shifted 2 bits so 0011 
        Console.WriteLine($"{num1} >> 2 = {result}");
        //the result is 3 because the bits are shifted to the right by 2 positions and the leftmost bits are filled with 0s
        
        result = num2 << 1;
        Console.WriteLine($"{num2} << 1 = {result}");
        //the result is 24 because the bits are shifted to the left by 1 position and the rightmost bit is filled with 0
    
    }
}
