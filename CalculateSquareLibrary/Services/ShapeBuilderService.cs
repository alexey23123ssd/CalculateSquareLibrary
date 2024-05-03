namespace CalculateSquareLibrary.Domain.Services
{
    public class ShapeBuilderService 
    {
        private readonly GeometricShape _geometricShape;
        public ShapeBuilderService(GeometricShape geometricShape)
        {
            _geometricShape = geometricShape;
        }

        public double CalculateSquare()
        {
            return _geometricShape.CalculateSquare();
        }

        public string WhatIsIt()
        {
            return _geometricShape.NameOfShape;
        }
    }
}
