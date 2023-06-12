public class Rectangle : Shape
{
    public Rectangle(string colour, double len, double wid) : base (colour)
        {
            _length = len;
            _width = wid;
        }
    private double _length;
    private double _width;
    public override double GetArea()
    {
        return _length * _width;
    }
}