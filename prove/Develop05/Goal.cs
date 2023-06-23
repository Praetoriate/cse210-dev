public class Goal
{
    //ATTRIBUTES
    protected string _name;
    protected string _description;
    protected bool _completed;
    protected int _xp;

    //CONSTRUCTORS
    public Goal(string name, string description, int xp)
    {
        _name = name;
        _description = description;
        _completed = false;
        _xp = xp;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetComplete(bool state)
    {
        _completed = state;
    }

    //METHODS
    public int ReturnXP()
    {
        return _xp;
    }

    public virtual bool IsComplete()
    {
        return _completed;
    }

    public virtual int RecordEvent()
    {
        return _xp;
    }

    public virtual void GetProgress()
    {

    }

    public virtual string TextAssemble()
    {
        string text = "";
        return text;
    }

    public virtual string EntryAssemble()
    {
        string entry = "";
        return entry;
    }

    public virtual Goal EntryLoad(string line)
    {
        Goal item = new Goal("test - goal.cs", "junk", 0);
        return item;
    }

}