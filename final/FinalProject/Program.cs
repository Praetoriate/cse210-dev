using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        Player system = new Player();
        Logger log = new Logger();

        //Menu Looop
        int option = 0;

        while (option != 5)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sample Water System SCADA");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(System is 'paused' while system is not showing)\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Menu Options:\n  1. Show System\n  2. History\n  3. Current Alarms\n  4. Controls\n  5. Quit");
            Console.Write("\nSelect a choice from the menu (1-5): ");
            string i = Console.ReadLine();
            option = int.Parse(i);

            if (option == 1) //Show System
            {
                system.SimulateSystem();

            }

            if (option == 2) //History
            {
                log.ReadHistory();
            }

            if (option == 3) //Current Alarms
            {

            }

            if (option == 4) //Controls
            {
                system.Controls();
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