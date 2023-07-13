public class WellPump : Pump
{
    //ATTRIBUTES
    Xmtr _wellLevel = new Xmtr(0);

    //CONSTRUCTORS

    //GETS & SETS
    public string GetLevelString()
    {
        string formatValue = string.Format("{0,4:#0.##}", _wellLevel.GetCV(), 5);
        return formatValue;
    }

    public float GetLevel()
    {
        return _wellLevel.GetCV();
    }

    //METHODS
    public override void RunLogic()
    {
        if (_running == true)
        {
            _wellLevel.SetCV(82.5f);
        }
        else
        {
            _wellLevel.SetCV(60.2f);
        }

        if (_runCmd == true)
        {
            _running = true;
        }
        if (_runCmd == false)
        {
            _running = false;
        }
    }

}