public class Player
{
    private string _name;
    private int _total;
    private List<Goal> _goals;

    public Player()
    {
        _name = "";
        _total = 0;
        _goals = new List<Goal>();
    }

    public void Config()
    {
        string[] lines = System.IO.File.ReadAllLines("settings.cfg");

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts[0] == "null")
            {
                Console.WriteLine("Please enter your player name: ");
                string playerName = Console.ReadLine();
                _name = playerName;
                using (StreamWriter output = new StreamWriter("settings.cfg"))
                {
                    output.WriteLine($"{playerName}");
                }
            }
            else
            {
                _name = parts[0];
            }
        }
    }


    public void AddGoal(Goal newGoal)
    {
        _goals.Add(newGoal);
        Console.WriteLine($"{newGoal.GetName()} has been added to the list.");
        Console.WriteLine("\nPress any key to return to the Main Menu...");
        Console.ReadKey();
    }

    public int TotalXP()
    {
        return _total;
    }

    public string GetName()
    {
        return _name;
    }

    public void ViewList()
    {
        Console.Clear();

        int number = 0;

        Console.WriteLine("The goals are: \n");
        foreach (Goal goal in _goals)
        {
            number++;
            Console.WriteLine($"{number}. {goal.TextAssemble()}");
        }
        Console.WriteLine("\nPress any key to return to the Main Menu...");
        Console.ReadKey();
    }

    public void SaveGoals()
    {
        Console.Write("Please enter the filename of your save file (eg. mysave.csv): ");
        string fileName = Console.ReadLine();
        Console.WriteLine("Saving to file... ");

        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(TotalXP());
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.EntryAssemble());
            }
        }
        Console.WriteLine("\nFile saved, press any key to return to the Main Menu...");
        Console.ReadKey();
    }

    public void LoadGoals()
    {
        _goals.Clear();

        Console.Write("Please enter the filename of the save file to load (eg. mysave.csv): ");
        string fileName = Console.ReadLine();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string i = reader.ReadLine();
            _total = Convert.ToInt32(i);
        }

        string[] lines = System.IO.File.ReadAllLines(fileName);
        lines = lines.Skip(1).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string type = parts[0];
            string name = parts[2];
            string description = parts[3];
            int xp = Convert.ToInt32(parts[4]);
            bool completed = Convert.ToBoolean(parts[1]);

            //Console.WriteLine($"{type}, {name}");
            //Console.ReadKey();

            if (type == "SimpleGoal")
            {
                SimpleGoal item = new SimpleGoal(name, description, xp);
                if (completed == true)
                {
                    item.SetComplete(true);
                }

                _goals.Add(item);
            }

            if (type == "EternalGoal")
            {
                EternalGoal item = new EternalGoal(name, description, xp);

                _goals.Add(item);
            }

            if (type == "ChecklistGoal")
            {
                int current = Convert.ToInt32(parts[5]);
                int target = Convert.ToInt32(parts[6]);
                int bonus = Convert.ToInt32(parts[7]);
                ChecklistGoal item = new ChecklistGoal(name, description, xp, target, current, bonus);

                if (completed == true)
                {
                    item.SetComplete(true);
                }

                _goals.Add(item);
            }
        }

        Console.WriteLine($"{fileName} has been loaded.");
        Console.WriteLine("\nPress any key to return to the Main Menu...");
        Console.ReadKey();
    }

    public void RecordEvent()
    {
        int number = 0;

        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            number++;
            Console.WriteLine($"{number}. {goal.GetName()}");
        }
        Console.Write($"Which Goal did you accomplish (1-{number})? ");
        string i = Console.ReadLine();
        int selection = int.Parse(i);
        selection = selection - 1;

        Goal finished = _goals[selection];

        int newXP = finished.RecordEvent();

        Console.Write($"Congrats! You just earned {newXP} experience points!");

        _total = _total + newXP;

        Console.WriteLine("\nPress any key to return to the Main Menu...");
        Console.ReadKey();
    }

}