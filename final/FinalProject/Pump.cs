public class Pump
{
    //ATTRIBUTES
    protected bool _runCmd;
    protected bool _running;

    //CONSTRUCTORS
    public Pump()
    {
        //null
    }

    //GETS & SETS
    public void SetRunCmd(bool cmd)
    {
        _runCmd = cmd;
    }

    public string GetRunStatus()
    {
        string status = "Not Running";
        if (_running == true)
        {
            status = "Running";
        }

        return status;
    }

    public void PrintStatus()
    {
        if (_running == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Running");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.WriteLine("Not Running");
        }
    }

    //METHODS
    public virtual void RunLogic()
    {

    }

}