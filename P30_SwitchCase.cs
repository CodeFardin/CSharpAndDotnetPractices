using System;

class SwitchCase
{
    public static void CheckAlphabet()
    {
        Console.WriteLine("Enter any Alphabet:");
        char alphabet = Convert.ToChar(Console.ReadLine());
        alphabet = char.ToLower(alphabet);

        switch (alphabet)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine($"{alphabet} is Vowel");
                break;
            default:
                Console.WriteLine($"{alphabet} is Consonant");
                break;
        }
    }

    public static void Main(string[] args)
    {
        // Alphabet check
        CheckAlphabet();

        // Number check
        Console.WriteLine("Enter any Number:");
        int number = Convert.ToInt32(Console.ReadLine());

        switch (number)
        {
            case 0: Console.WriteLine("Zero"); break;
            case 1: Console.WriteLine("One"); break;
            case 2: Console.WriteLine("Two"); break;
            case 3: Console.WriteLine("Three"); break;
            case 4: Console.WriteLine("Four"); break;
            case 5: Console.WriteLine("Five"); break;
            case 6: Console.WriteLine("Six"); break;
            case 7: Console.WriteLine("Seven"); break;
            case 8: Console.WriteLine("Eight"); break;
            case 9: Console.WriteLine("Nine"); break;
            default: Console.WriteLine("Invalid Digit"); break;
        }
    }
}