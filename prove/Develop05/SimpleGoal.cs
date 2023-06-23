public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int xp) : base(name, description, xp)
    {
        _name = name;
        _description = description;
        _completed = IsComplete();
        _xp = xp;
    }

    public override int RecordEvent()
    {
        SetComplete(true);
        int totalXP = ReturnXP();

        return totalXP;
    }

    public override string TextAssemble()
    {
        string holder = "?";

        if (_completed == true)
        {
            holder = "X";
        }

        if (_completed == false)
        {
            holder = " ";
        }

        string text = $"[{holder}] {_name} ({_description})";
        return text;
    }

    public override string EntryAssemble()
    {
        string edited = GetDescription();
        edited = edited.Replace(',', '|');
        string entry = $"SimpleGoal,{IsComplete()},{GetName()},{edited},{_xp}";
        return entry;
    }

}