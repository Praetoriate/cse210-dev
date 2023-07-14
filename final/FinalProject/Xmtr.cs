public class Xmtr
{
    //ATTRIBUTES
    private float _currentValue;

    //CONSTRUCTORS
    public Xmtr(float cv)
    {
        _currentValue = cv;
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