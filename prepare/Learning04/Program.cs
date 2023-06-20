using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(assignment2.GetHomework());

        WritingAssignment assignment3 = new WritingAssignment("Mary Waters", "European History", "The Causes of WWII");
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}