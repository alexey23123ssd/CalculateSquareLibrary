namespace CalculateSquareLibrary.Domain;
public class Circle : GeometricShape
{
    private double _radius { get; set; }
    public override string NameOfShape { get; protected set; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("the values cannot be less than or equal to zero");
        }
        _radius = radius;
        NameOfShape = nameof(Circle);
    }
    public override double CalculateSquare()
    {
        Square = _radius * _radius * Math.PI;
        return Square;
    }

    public override double CalculatePerimetr()
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        return this.Square == (obj as Circle).Square;
    }
}

