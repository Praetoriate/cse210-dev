using System;
using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    
    {
        List<int> numbers = new List<int>();

        bool cont = true;
        float sum = 0;
        int largest = -1;

        while (cont == true)
        {
            Console.Write("Please enter a number: ");
            string i = Console.ReadLine();
            int numNew = int.Parse(i);
            
            if (numNew != 0)
            {
                numbers.Add(numNew);
            }

            if (numNew == 0)
            {
                cont = false;
            }
        }

        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        foreach (int number in numbers)
        {
            if (largest < number)
            {
                largest = number;
            }
        }

        int count = numbers.Count;
        float average = sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}