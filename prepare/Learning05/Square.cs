public class Square : Shape
{
    public Square(string colour, double side) : base (colour)
        {
            _side = side;
        }
    private double _side;
    public override double GetArea()
    {
        return _side * _side;
    }
}