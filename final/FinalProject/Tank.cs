public class Tank
{
    //ATTRIBUTES
    private float _level;
    protected float _height;

    Xmtr level = new Xmtr(0);

    //CONSTRUCTORS
    public Tank()
    {
    }

    //GETS & SETS
    public string GetLevelString()
    {
        string formatValue = string.Format("{0,4:#0.##}", level.GetCV(), 5);
        return formatValue;
    }

    public float GetLevel()
    {
        return _level;
    }

    public void SetLevel(float cv)
    {
        level.SetCV(cv);
        _level = level.GetCV();
    }

    //METHODS

}