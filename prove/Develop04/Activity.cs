public class Activity
{
    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //Constructors
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //Gets and Sets

    //Methods
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string i = Console.ReadLine();
        _duration = int.Parse(i);

        Console.Clear();
        Console.WriteLine($"Get ready!\n{_name} will begin shortly.");
        SpinPause(10);
    }

    public void StopActivity()
    {
        Console.WriteLine("\nWell done!!");
        SpinPause(5);
        string summary = $"You have completed another {_duration} seconds of the {_name}.";

        Log logFile = new Log();
        logFile.AddToLog(summary);

        Console.WriteLine($"\n{summary}\n\nYou will be returned to the main menu.");
        SpinPause(5);
    }

    public void SpinPause(int seconds)
    {
        List<string> doots = new List<string>();
        doots.Add("|");
        doots.Add("/");
        doots.Add("-");
        doots.Add("\\");
        doots.Add("|");
        doots.Add("/");
        doots.Add("-");
        doots.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string doot in doots)
            {
                Console.Write(doot);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }

    public void CountPause(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b    \b\b\b\b");
        }
    }

}