using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magNum = randomGenerator.Next(1, 101);

        Console.Write("What is your guess? ");
        string j = Console.ReadLine();
        int guess = int.Parse(j);

        while (magNum != guess)
        {


            if (magNum > guess)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your next guess? ");
                    j = Console.ReadLine();
                    guess = int.Parse(j);
                }

                if (magNum < guess)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your next guess? ");
                    j = Console.ReadLine();
                    guess = int.Parse(j);
                }

                if (magNum == guess)
                {
                    Console.Write("You got it!");
                }
        }
    }
}