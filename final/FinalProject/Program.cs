using System;

class Program
{
    static void Main(string[] args)
    {
        //System Assets
        BoosterPump boosterA = new BoosterPump();

        //Menu Looop
        int option = 0;

        while (option != 5)
        {
            Console.Clear();
            Console.WriteLine("Sample Water System SCADA\n");
            Console.WriteLine("Menu Options:\n  1. Show System\n  2. History\n  3. Current Alarms\n  4. Controls\n  5. Quit");
            Console.Write("Select a choice from the menu (1-5): ");
            string i = Console.ReadLine();
            option = int.Parse(i);

            if (option == 1) //Show System
            {

                Console.Clear();
                Console.WriteLine("This is where you'll see the current state of all the objects\n");

                Console.Write($"Booster A: ");
                boosterA.PrintStatus();

                Console.WriteLine("\nPress any key to return to the Main Menu...");
                Console.ReadKey();

            }

            if (option == 2) //History
            {
                Console.Clear();

            }

            if (option == 3) //Current Alarms
            {

            }

            if (option == 4) //Controls
            {
                int control = 0;

                Console.Clear();
                Console.Write("Booster A Control\n\nCurrently: ");
                boosterA.PrintStatus();
                Console.WriteLine("\nMenu Options:\n  1. Turn on\n  2. Turn off\n  3. Cancel");
                Console.Write("Select a choice from the menu (1-3): ");
                string j = Console.ReadLine();
                control = int.Parse(j);

                if (control == 1)
                {
                    boosterA.SetRunCmd(true);
                    boosterA.RunLogic();
                }

                if (control == 2)
                {
                    boosterA.SetRunCmd(false);
                    boosterA.RunLogic();
                }

            }

            if (option == 5) //Quit
            {
                Console.WriteLine("\n** Please conserve, and be water-wise! **\n");
            }

            if (option != 5)
            {
                option = 0;
            }
        }

    }
}