public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int SetTop(int top)
    {
        return _top = top;
    }

    public int GetBottom()
    {
        return _top;
    }

    public int SetBottom(int top)
    {
        return _top = top;
    }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    public double GetDecimalValue()
    {
        double topValue = _top;
        double bottomValue = _bottom;
        return topValue / bottomValue;
    }
}