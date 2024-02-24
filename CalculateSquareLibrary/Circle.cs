namespace ConsoleApp8
{
    public class Circle : GeometricShape
    {
        public double _radius { get; set; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("the values cannot be less than or equal to zero");
            }
            _radius = radius;
        }
        public override double CalculateSquare()
        {
            var square = _radius * _radius * Math.PI;
            return square;
        }
    }
}
