public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = duration;

        List<string> prompts = new List<string>();
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");
        _prompts = prompts;

        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        _questions = questions;
    }

    public void Reflect()
    {
        int elapsedTime = 0;

        StartActivity();

        Random rando1 = new Random();
        int i = rando1.Next(_prompts.Count());
        string promptSelected = _prompts[i];

        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"--- {promptSelected} ---");
        Console.WriteLine("\nWhen you have something in mind, press any key to continue.");
        Console.ReadKey();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.\nYou may begin in:");
        CountPause(5);

        Console.Clear();

        while (elapsedTime <= _duration)
        {
            Random rando2 = new Random();
            int j = rando2.Next(_questions.Count());
            string questionSelected = _questions[j];

            Console.WriteLine($"> {questionSelected}");
            int delay = 7;
            SpinPause(delay);

            elapsedTime = elapsedTime + delay;
        }

        StopActivity();
    }
}