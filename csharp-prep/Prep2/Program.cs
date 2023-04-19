using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage (##)? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade); 
        
        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }

        if (number <90 && number >= 80)
        {
            letter = "B";
        }

        if (number <80 && number >= 70)
        {
            letter = "C";
        }

        if (number <70 && number >= 60)
        {
            letter = "D";
        }

        if (number <60)
        {
            letter = "F";
        }

        Console.WriteLine($"You received the grade: {letter}.");

        if (number >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Try again.");
        }
    }
}