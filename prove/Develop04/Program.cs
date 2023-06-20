using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        Log logFile = new Log();

        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. View log\n  5. Clear Log\n  6. Quit");
            Console.Write("Select a choice from the menu (1-6): ");
            string i = Console.ReadLine();
            option = int.Parse(i);

            if (option == 1) //Breathing
            {
                BreatheActivity Breathe1 = new BreatheActivity("Fun activity", "This is supposed to help your brain, man...", 30, 4, 6);
                Breathe1.Breathe();
            }

            if (option == 2) //Reflection
            {
                ReflectionActivity Reflect1 = new ReflectionActivity("Fun activity", "This is supposed to help your brain, man...", 30);
                Reflect1.Reflect();
            }

            if (option == 3) //Listing 
            {
                ListingActivity List1 = new ListingActivity("Fun activity", "This is supposed to help your brain, man...", 30);
                List1.ListEntry();
            }

            if (option == 4) //ViewLog
            {
                logFile.ViewLog();
            }

            if (option == 5) //ClearLog
            {
                logFile.ClearLog();
            }

            if (option == 6) //Quit
            {
                Console.WriteLine("\nUntil next time, be well.\n");
            }

            if (option != 6)
            {
                option = 0;
            }
        }

    }
}