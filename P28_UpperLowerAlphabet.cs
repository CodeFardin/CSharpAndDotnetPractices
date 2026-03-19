using System;
public class VowelCons
{
    public static void Main(string[] args)
    {
        // Vowel - a,e,i,o,u
        // Consonant - b,c,d,f,g,h,j,k,l,m,n,p,q,r,s,t,v,w,x,y,z

        Console.WriteLine("Enter Any Alphabet: ");
        char alphabet = Convert.ToChar(Console.ReadLine());

        if (alphabet >= 'A' && alphabet <= 'Z')
        {
            Console.WriteLine($"{alphabet} is a Capital Letter");
        }
        else
        {
            Console.WriteLine($"{alphabet} is a Small Letter");

        }
    }
}