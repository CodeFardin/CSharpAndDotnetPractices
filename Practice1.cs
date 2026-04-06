ShowTitle();

int markOfPhysics = MarksInput("Physics");
int markOfChemistry = MarksInput("Chemistry");
int markOfBiology = MarksInput("Biology");
TotalMark(markOfPhysics, markOfBiology, markOfChemistry);
AvgMark(markOfPhysics, markOfBiology, markOfChemistry);

void ShowTitle()
{
    System.Console.WriteLine("________Welcome________");
    System.Console.WriteLine("Student Result Calculator");
    System.Console.WriteLine("Enter Your Marks");
}

int MarksInput(string sub)
{
    System.Console.Write($"Enter your number for {sub}: ");
    bool isValid = int.TryParse(Console.ReadLine(), out int mark);
    if(!isValid || mark < 0 || mark > 100)
    {
        System.Console.WriteLine("Wrong input. Try Again!");
        MarksInput(sub);
    } 

    return mark;
} 

void TotalMark(int mark1, int mark2, int mark3)
{
    int totalMarks = mark1 + mark2 + mark3;
    System.Console.WriteLine($"Total Mark: {totalMarks}");

}

void AvgMark(int mark1, int mark2, int mark3)
{
    int avgMarks = (mark1 + mark2 + mark3)/3;
    System.Console.WriteLine($"Average Mark: {avgMarks}");
}