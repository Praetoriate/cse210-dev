
using System.Diagnostics;
public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = duration;

        List<string> prompts = new List<string>();
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        _prompts = prompts;

    }

    public void ListEntry()
    {
        int elapsedTime = 0;
        List<string> entries = new List<string>();

        StartActivity();

        Random rando1 = new Random();
        int i = rando1.Next(_prompts.Count());
        string promptSelected = _prompts[i];

        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($"--- {promptSelected} ---");
        Console.WriteLine("You may begin in:");
        CountPause(5);

        while (elapsedTime <= _duration)
        {
            Stopwatch timer = Stopwatch.StartNew();

            Console.Write("> ");
            string k = Console.ReadLine();
            entries.Add(k);

            timer.Stop();
            int totalTime = Convert.ToInt32(timer.Elapsed.TotalSeconds);
            elapsedTime = elapsedTime + totalTime;
        }

        Console.WriteLine($"You listed {entries.Count()} items!");

        StopActivity();
    }
}