public class BreatheActivity : Activity
{
    private int _inTime;
    private int _outTime;

    public BreatheActivity(string name, string description, int duration, int inTime, int outTime) : base(name, description, duration)
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = duration;
        _inTime = inTime;
        _outTime = outTime;
    }

    public void Breathe()
    {
        int elapsedTime = 0;

        StartActivity();

        while (elapsedTime <= _duration)
        {
            Console.WriteLine("\nBreathe in... ");
            CountPause(_inTime);
            Console.WriteLine("Now breathe out... ");
            CountPause(_outTime);
            elapsedTime = elapsedTime + _inTime + _outTime;
        }

        StopActivity();

    }


}