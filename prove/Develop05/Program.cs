using System;

class Program
{
    static void Main(string[] args)

    // Program requirements are exceeded with the addition of the player.Config() method, that uses a settings.cfg file
    // to get the player name the first time the program is run. Every subsequent time the program runs, it will load the 
    // player name from this file.

    {
        Player player = new Player();

        player.Config();

        //Menu Loop
        int option = 0;

        while (option != 6)
        {
            Console.Clear();
            Console.WriteLine($"Hello {player.GetName()}, you have {player.TotalXP()} xp!\n");
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit");
            Console.Write("Select a choice from the menu (1-6): ");
            string i = Console.ReadLine();
            option = int.Parse(i);

            if (option == 1) //Create New Goal
            {
                //INPUT 
                Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
                Console.Write("Which type of Goal would you like to create (1-3)? ");
                string j = Console.ReadLine();
                int thingy = int.Parse(j);

                if (thingy == 1)
                {
                    Console.Write("What would you like to call this Goal? ");
                    string name = Console.ReadLine();

                    Console.Write("Whats a good description of this Goal? ");
                    string description = Console.ReadLine();

                    Console.Write("And How much XP is this worth? ");
                    string k = Console.ReadLine();
                    int xp = int.Parse(k);

                    SimpleGoal simple1 = new SimpleGoal(name, description, xp);
                    player.AddGoal(simple1);
                }

                if (thingy == 2)
                {
                    Console.Write("What would you like to call this Goal? ");
                    string name = Console.ReadLine();

                    Console.Write("Whats a good description of this Goal? ");
                    string description = Console.ReadLine();

                    Console.Write("And how much XP is each event worth? ");
                    string l = Console.ReadLine();
                    int xp = int.Parse(l);

                    EternalGoal eternal1 = new EternalGoal(name, description, xp);
                    player.AddGoal(eternal1);
                }

                if (thingy == 3)
                {
                    Console.Write("What would you like to call this Goal? ");
                    string name = Console.ReadLine();

                    Console.Write("Whats a good description of this Goal? ");
                    string description = Console.ReadLine();

                    Console.Write("How much XP is each event worth? ");
                    string l = Console.ReadLine();
                    int xp = int.Parse(l);

                    Console.Write("How many times do you need to complete this before finishing the Goal? ");
                    string m = Console.ReadLine();
                    int target = int.Parse(m);

                    Console.Write("How how much bonus XP do you get when you finish the Goal? ");
                    string n = Console.ReadLine();
                    int bonus = int.Parse(n);

                    ChecklistGoal check1 = new ChecklistGoal(name, description, xp, target, 0, bonus);
                    player.AddGoal(check1);
                }


            }

            if (option == 2) //List Goals
            {
                player.ViewList();
            }

            if (option == 3) //Save Goals 
            {
                player.SaveGoals();
            }

            if (option == 4) //Load Goals
            {
                player.LoadGoals();
            }

            if (option == 5) //Record Event
            {
                player.RecordEvent();
            }

            if (option == 6) //Quit
            {
                Console.WriteLine("\nDon't forget to brush your teeth.\n");
            }

            if (option != 6)
            {
                option = 0;
            }
        }

    }

}