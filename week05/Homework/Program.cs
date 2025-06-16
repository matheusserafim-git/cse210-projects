using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Effraim Hanks", "calculus");
        Console.WriteLine(a1.GetSummary());
        MathAssigment a2 = new MathAssigment("7.3", "8-19", "Joseph Smith", "phisosophy");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());
        WritingAssignment a3 = new WritingAssignment("Joshua Steed", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());

    }
}