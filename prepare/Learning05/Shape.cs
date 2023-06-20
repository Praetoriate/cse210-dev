public class Shape
{
    public Shape(string colour)
    {
        _colour = colour;
    }
    private string _colour;
    public string GetColour()
    {
        return _colour;
    }
    public void SetColour(string colour)
    {
        _colour = colour;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}