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

            Console.WriteLine("Menu Options:\n  1. Show System\n  2. History\n  3. System Help\n  4. Controls\n  5. Quit");
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

            if (option == 3) //System Help
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sample Water System SCADA Help Documentation");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("SCADA info and water system operational narrative. Press any key to return to the Main Menu.\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("The purpose of a SCADA System is to monitor, and allow control of, devices or systems within a distributed network. Data from the devices in the system are monitored in 'real time' and logged (historized) into a database. These systems are used in many industries, locations, and applications.\n\nThis program simulates a small water system, similar to what you would find in a small town. There are 2 pressure zones, or distribution areas, that are supplied by water in their respective tanks, 1 and 2. Customer usage is included in the simulation as a constant draw on the tank levels.\n\nTank 1 is supplied water by Well 1, which will come on when the tank gets too low and turn off when the tank gets too high. Boosters A and B fill separate vessels of Tank 2 using water from Tank 1. They will shut off if Tank 1 gets too low or their side of Tank 2 gets too high. They will come back on if their side of Tank 2 gets too low.\n\nThe System 'scans' each second and the data is captured with a timestamp. In a real system this would happen asycronously across multiple areas in the system. This data can be accessed from the database (in this case a .csv file), displayed, and exported as needed.");

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
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