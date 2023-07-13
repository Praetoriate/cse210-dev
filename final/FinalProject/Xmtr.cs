public class Xmtr
{
    //ATTRIBUTES
    private float _currentValue;
    private bool _hiAlm;
    private bool _loAlm;

    //CONSTRUCTORS
    public Xmtr(float cv)
    {
        _currentValue = cv;

        Alarm hiAlm = new Alarm(_currentValue,true);
        Alarm loAlm = new Alarm(_currentValue,false);

        _hiAlm = hiAlm.GetAlarmState();
        _loAlm = loAlm.GetAlarmState();
    }
    
    //GETS & SETS
    public void SetCV(float cv)
    {
        _currentValue = cv;
    }

    public float GetCV()
    {
        return _currentValue;
    }

    //METHODS

}