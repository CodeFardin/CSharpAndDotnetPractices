public class StringInt
{
    public static void Main(string[] args)
    {
    while(true)
    {
        Console.Write("Enter a number from 1 to 10 or quit to exit the app: ");

        string input = Console.ReadLine() ?? "";
        input = input.ToLower().Trim();
        //trim diye space gulo shoriye naoa hoi

        if ( input == "quit")
            {
                Console.WriteLine("Thanks for using, goodbye");
                break;
            }
        if ( !int.TryParse(input, out int number))
            {
                 Console.WriteLine($"Enter a valid input, Please give a number ");
                continue;
            }
            int square = number * number;
            Console.WriteLine($"Square of {number} = {square}");
        if(!(number >= 1 && number <=10))
            {
                Console.WriteLine($"{number} is not in range");
                continue;
            }


    } 
    }
}