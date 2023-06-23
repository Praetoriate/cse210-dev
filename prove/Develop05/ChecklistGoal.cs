public class ChecklistGoal : Goal
{
    private int _target;
    private int _current;
    private int _bonus;
    public ChecklistGoal(string name, string description, int xp, int target, int current, int bonus) : base(name, description, xp)
    {
        _name = name;
        _description = description;
        _completed = false;
        _xp = xp;
        _target = target;
        _current = current;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _current++;
        int totalXP = 0;

        if (_current == _target)
        {
            SetComplete(true);
            totalXP = _xp + _bonus;
        }
        else
        {
            totalXP = _xp;
        }

        return totalXP;

    }

    public override string TextAssemble()
    {
        string holder = " ";

        if (_completed == true)
        {
            holder = "X";
        }

        string text = $"[{holder}] {_name} ({_description}) -- Currently completed: {_current}/{_target}";
        return text;
    }

    public override string EntryAssemble()
    {
        string edited = GetDescription();
        edited = edited.Replace(',', '|');
        string entry = $"ChecklistGoal,{IsComplete()},{GetName()},{edited},{_xp},{_current},{_target},{_bonus}";
        return entry;
    }
}