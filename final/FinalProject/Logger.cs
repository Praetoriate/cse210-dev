public class Logger
{
    //ATTRIBUTES

    //CONSTRUCTORS

    //GETS & SETS

    //METHODS
    public void WriteHistory()
    {
        //Migrated to Player.cs
    }

    public void ReadHistory()
    {
        int historySelect = 0;
        string filePath = "history.csv";

        string text = File.ReadAllText(filePath);

        List<string> lines = new List<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream)
            {
                lines.Add(reader.ReadLine());
            }
        }

        while (historySelect != 8)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("SCADA Data History");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Show all data or data for specific data point.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Menu Options:\n  1. Show all data\n  2. Well 1 (state and level)\n  3. Tank 1 Level\n  4. Booster A State\n  5. Booster B State\n  6. Tank 2 Level 1\n  7. Tank 2 Level 2\n  8. Return to Main Menu");
            Console.Write("\nSelect a choice from the menu (1-8): ");
            string j = Console.ReadLine();
            historySelect = int.Parse(j);

            if (historySelect == 1)
            {
                foreach (string line in lines)
                {
                    string[] dataPoints = line.Split(",");
                    Console.WriteLine($"{dataPoints[0],20}{dataPoints[1],15}{dataPoints[2],12}{dataPoints[3],15}{dataPoints[4],17}{dataPoints[5],17}{dataPoints[6],15}{dataPoints[7],15}");
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }

            if (historySelect == 2)
            {
                foreach (string line in lines)
                {
                    string[] dataPoints = line.Split(",");
                    Console.WriteLine($"{dataPoints[0],20}{dataPoints[1],15}{dataPoints[2],12}");
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }

            if (historySelect == 3)
            {
                foreach (string line in lines)
                {
                    string[] dataPoints = line.Split(",");
                    Console.WriteLine($"{dataPoints[0],20}{dataPoints[3],15}");
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();

            }

            if (historySelect == 4)
            {
                foreach (string line in lines)
                {
                    string[] dataPoints = line.Split(",");
                    Console.WriteLine($"{dataPoints[0],20}{dataPoints[4],17}");
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }

            if (historySelect == 5)
            {
                foreach (string line in lines)
                {
                    string[] dataPoints = line.Split(",");
                    Console.WriteLine($"{dataPoints[0],20}{dataPoints[5],17}");
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }

            if (historySelect == 6)
            {
                foreach (string line in lines)
                {
                    string[] dataPoints = line.Split(",");
                    Console.WriteLine($"{dataPoints[0],20}{dataPoints[6],15}");
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }

            if (historySelect == 7)
            {
                foreach (string line in lines)
                {
                    string[] dataPoints = line.Split(",");
                    Console.WriteLine($"{dataPoints[0],20}{dataPoints[7],15}");
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }

            if (historySelect == 8)
            {
                //Quit
            }

        }

    }

}