using System;
public class VowelCons
{
    public static void Main(string[] args)
    {
        // Vowel - a,e,i,o,u
        // Consonant - b,c,d,f,g,h,j,k,l,m,n,p,q,r,s,t,v,w,x,y,z

        Console.WriteLine("Enter any Alphabet: ");
        char alphabet = Convert.ToChar(Console.ReadLine());

        alphabet = char.ToLower(alphabet);
        
        //above ToLower Converts alphabets to lower case
         if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')
        {
            Console.WriteLine($"{alphabet} is a Vowel");
        }
        else
        {
            Console.WriteLine($"{alphabet} is a Consonant");
        }
    }
}