using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Andrew", "Python");
        Console.WriteLine(assignment1.GetSummary());


        MathAssignment mathassignment1 = new MathAssignment("Andrew", "Adding", "addingstuff", "1-2");
        Console.WriteLine(mathassignment1.GetSummary());
        Console.WriteLine(mathassignment1.GetHomeworkList());

        WritingAssignment writingassignment1 = new WritingAssignment("Andrew", "English", "Beans");
        Console.WriteLine(writingassignment1.GetSummary());
        Console.WriteLine(writingassignment1.GetWritingInfo());


    }
}