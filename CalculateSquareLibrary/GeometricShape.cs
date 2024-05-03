namespace CalculateSquareLibrary.Domain
{
    public abstract class GeometricShape
    {
        public abstract string NameOfShape { get; protected set; }
        public double Perimetr { get; protected set; }
        public double Square { get; protected set; }
        public abstract double CalculatePerimetr();
        public abstract double CalculateSquare();
    }
}
