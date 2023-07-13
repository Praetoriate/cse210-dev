public class Player
{
    //System Assets
    WellPump well1 = new WellPump();
    BoosterPump boosterA = new BoosterPump();
    BoosterPump boosterB = new BoosterPump();
    SingleTank tank1 = new SingleTank(30f);
    DoubleTank tank2 = new DoubleTank(30f, 50f);

    //ATTRIBUTES

    //CONSTRUCTORS

    //GETS & SETS

    //METHODS
    public void SimulateSystem()
    {
        int count = 0;

        //Load tank levels from last runtime
        string loadValues = File.ReadLines("history.csv").Last();
        string[] split = loadValues.Split(",");
        tank1.SetLevel(float.Parse(split[3]));
        tank2.SetLevel(float.Parse(split[6]));
        tank2.SetLevel2(float.Parse(split[7]));

        while (!Console.KeyAvailable)
        {
            count++;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sample Water System SCADA\n------------------------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Well 1: ");
            well1.PrintStatus();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Well 1 Level: ");
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{well1.GetLevelString()} ft");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n  |\n  V");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nTank 1 Level: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{tank1.GetLevelString()} ft");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n  |\n  V");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nBooster A: ");
            boosterA.PrintStatus();
            Console.Write("Booster B: ");
            boosterB.PrintStatus();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n  |\n  V");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nTank 2 Level 1: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{tank2.GetLevelString()} ft");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Tank 2 Level 2: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{tank2.GetLevel2String()} ft");
            Console.ForegroundColor = ConsoleColor.White;


            //Console.WriteLine($"step 1 {count}");

            Console.WriteLine("\nPress any key to return to the Main Menu and pause the system...");

            SimulateLogic();
            LogData();

            Thread.Sleep(1000);


        }

        ConsoleKeyInfo key = Console.ReadKey(true);


    }

    public void LogData()
    {
        List<string> currentValues = new List<string>();

        DateTime theCurrentTime = DateTime.Now;
        string currentTime = theCurrentTime.ToString();

        currentValues.Add(currentTime);
        currentValues.Add(well1.GetRunStatus());
        currentValues.Add(well1.GetLevelString());
        currentValues.Add(tank1.GetLevelString());
        currentValues.Add(boosterA.GetRunStatus());
        currentValues.Add(boosterB.GetRunStatus());
        currentValues.Add(tank2.GetLevelString());
        currentValues.Add(tank2.GetLevel2String());

        using (FileStream filer = new FileStream("history.csv", FileMode.Append, FileAccess.Write))
        {
            using (StreamWriter output = new StreamWriter(filer))
            {
                output.Write("\n");
                foreach (string dataPoint in currentValues)
                {
                    output.Write(dataPoint);
                    output.Write(",");
                }
            }
        }
    }

    public void SimulateLogic()
    {
        //Well logic
        if (well1.GetRunStatus() == "Running")
        {
            float level = tank1.GetLevel();
            level = level + 3f;
            tank1.SetLevel(level);
        }

        if (tank1.GetLevel() > 25f)
        {
            well1.SetRunCmd(false);
        }

        if (tank1.GetLevel() < 8f)
        {
            well1.SetRunCmd(true);
        }

        well1.RunLogic();

        //BoosterA Logic
        if (boosterA.GetRunStatus() == "Running")
        {
            float draw = tank1.GetLevel();
            draw = draw - 1f;
            tank1.SetLevel(draw);

            float fill = tank2.GetLevel();
            fill = fill + 1f;
            tank2.SetLevel(fill);
        }

        if (tank2.GetLevel() > 25f)
        {
            boosterA.SetRunCmd(false);
        }

        if (tank2.GetLevel() < 4f)
        {
            boosterA.SetRunCmd(true);
        }

        if (tank1.GetLevel() < 5f)
        {
            boosterA.SetRunCmd(false);
        }



        boosterA.RunLogic();

        //BoosterB Logic
        if (boosterB.GetRunStatus() == "Running")
        {
            float draw = tank1.GetLevel();
            draw = draw - 1.5f;
            tank1.SetLevel(draw);

            float fill = tank2.GetLevel2();
            fill = fill + 1.5f;
            tank2.SetLevel2(fill);
        }

        if (tank2.GetLevel2() > 45f)
        {
            boosterB.SetRunCmd(false);
        }

        if (tank2.GetLevel2() < 4f)
        {
            boosterB.SetRunCmd(true);
        }

        if (tank1.GetLevel() < 6f)
        {
            boosterB.SetRunCmd(false);
        }

        boosterB.RunLogic();

        //System Demand

        float zone1 = tank1.GetLevel();
        zone1 = zone1 - .74f;
        tank1.SetLevel(zone1);

        float zone2 = tank2.GetLevel();
        zone2 = zone2 - .28f;
        tank2.SetLevel(zone2);

        float zone3 = tank2.GetLevel2();
        zone3 = zone3 - .46f;
        tank2.SetLevel2(zone3);


    }

    public void Controls()
    {
        //Menu Looop
        int option = 0;

        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Pump Manual Controls\n");
            Console.WriteLine("Menu Options:\n  1. Well 1\n  2. Booster A\n  3. Booster B\n  4. Return to Main Menu");
            Console.Write("\nSelect a choice from the menu (1-4): ");
            string i = Console.ReadLine();
            option = int.Parse(i);

            if (option == 1) //Well 1
            {
                int controlWell1 = 0;

                Console.Clear();
                Console.Write("Well 1 Control\n\nCurrently: ");
                well1.PrintStatus();
                Console.WriteLine("\nMenu Options:\n  1. Turn on\n  2. Turn off\n  3. Cancel");
                Console.Write("\nSelect a choice from the menu (1-3): ");
                string j = Console.ReadLine();
                controlWell1 = int.Parse(j);

                if (controlWell1 == 1)
                {
                    well1.SetRunCmd(true);
                    well1.RunLogic();
                }

                if (controlWell1 == 2)
                {
                    well1.SetRunCmd(false);
                    well1.RunLogic();
                }

            }

            if (option == 2) //Booster A
            {
                int controlBstrA = 0;

                Console.Clear();
                Console.Write("Booster A Control\n\nCurrently: ");
                boosterA.PrintStatus();
                Console.WriteLine("\nMenu Options:\n  1. Turn on\n  2. Turn off\n  3. Cancel");
                Console.Write("\nSelect a choice from the menu (1-3): ");
                string j = Console.ReadLine();
                controlBstrA = int.Parse(j);

                if (controlBstrA == 1)
                {
                    boosterA.SetRunCmd(true);
                    boosterA.RunLogic();
                }

                if (controlBstrA == 2)
                {
                    boosterA.SetRunCmd(false);
                    boosterA.RunLogic();
                }

            }

            if (option == 3) //Booster B
            {
                int controlBstrB = 0;

                Console.Clear();
                Console.Write("Booster B Control\n\nCurrently: ");
                boosterB.PrintStatus();
                Console.WriteLine("\nMenu Options:\n  1. Turn on\n  2. Turn off\n  3. Cancel");
                Console.Write("\nSelect a choice from the menu (1-3): ");
                string j = Console.ReadLine();
                controlBstrB = int.Parse(j);

                if (controlBstrB == 1)
                {
                    boosterB.SetRunCmd(true);
                    boosterB.RunLogic();
                }

                if (controlBstrB == 2)
                {
                    boosterB.SetRunCmd(false);
                    boosterB.RunLogic();
                }

            }

            if (option == 4) //Return to Main Menu
            {

            }

        }

    }
}