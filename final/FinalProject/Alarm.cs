public class Alarm
{
    //ATTRIBUTES
    private float _setpoint;
    private bool _inAlarm;
    private float _processValue;
    private bool _comparator;

    //CONSTRUCTORS
    public Alarm(float pv, bool compare)
    {
        _processValue = pv;
        _comparator = compare;
    }

    //GETS & SETS
    public bool GetAlarmState()
    {
        return _inAlarm;
    }

    public void WriteSP(float sp)
    {
        _setpoint = sp;
    }

    public float ReadSP()
    {
        return _setpoint;
    }

    public void SetPV(float pv)
    {
        _processValue = pv;
    }

    //METHODS
    public bool AlarmLogic()
    {
        bool alm = false;

        if (_comparator == false)
        {
            //ALM LOGIC
        }

        if (_comparator == true)
        {
            //ALM LOGIC
        }

        return alm;
    }




}