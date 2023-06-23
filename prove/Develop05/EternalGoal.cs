public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int xp) : base(name, description, xp)
    {
        _name = name;
        _description = description;
        _completed = false;
        _xp = xp;
    }

    public override int RecordEvent()
    {
        return _xp;
    }

    public override string TextAssemble()
    {
        string holder = " ";

        if (_completed == true)
        {
            holder = "X";
        }

        string text = $"[{holder}] {_name} ({_description})";
        return text;
    }

    public override string EntryAssemble()
    {
        string edited = GetDescription();
        edited = edited.Replace(',', '|');
        string entry = $"EternalGoal,{IsComplete()},{GetName()},{edited},{_xp}";
        return entry;
    }
}