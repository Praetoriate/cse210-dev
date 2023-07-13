public class DoubleTank : Tank
{
    //ATTRIBUTES
    private float _level2;
    private float _height2;
    Xmtr level2 = new Xmtr(0);

    //CONSTRUCTORS
    public DoubleTank(float height1, float height2)
    {
        _height = height1;
        _height2 = height2;
    }

    //GETS & SETS
    public string GetLevel2String()
    {
        string formatValue = string.Format("{0,4:#0.##}", level2.GetCV(), 5);
        return formatValue;
    }

    public float GetLevel2()
    {
        return _level2;
    }

    public void SetLevel2(float cv)
    {
        level2.SetCV(cv);
        _level2 = level2.GetCV();
    }
    //METHODS
    public bool DifferentialAlm()
    {
        bool alm = false;
        //Alarm Logic
        return alm;
    }

}