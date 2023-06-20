public class Circle : Shape
{
    public Circle(string colour, double rad) : base(colour)
    {
        _radius = rad;
    }
    private double _radius;
    public override double GetArea()
    {
        return 3.14 * (_radius * _radius);
    }
}