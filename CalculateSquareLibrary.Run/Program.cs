using CalculateSquareLibrary.Domain;
using CalculateSquareLibrary.Domain.Services;

namespace CalculateSquareLibrary.Run
{
    public class Program
    {
        public const double cirlceTestValue = 314;
        public const double triangleTestValue = 2.905;

        static void Main(string[] args)
        {
            double radius = 10;
            GeometricShape shape = new Circle(radius);
            ShapeBuilderService shapeBuilder = new ShapeBuilderService(shape);

            var circleSquare = shapeBuilder.CalculateSquare();
            if(Math.Round(circleSquare) == cirlceTestValue)
            {
                Console.WriteLine("Circle Created");
            }

            double firstSide = 3;
            double secondSide = 2;
            double thirdSide = 4;
            GeometricShape geometricShape = new Triangle(firstSide,secondSide,thirdSide);
            ShapeBuilderService shapeBuilderService = new ShapeBuilderService(geometricShape);

            var triangleSquare = shapeBuilderService.CalculateSquare();
            if(Math.Round(triangleSquare,3) == triangleTestValue)
            {
                Console.WriteLine("Triangle Created");
            }

            Console.ReadLine();
        }
    }
    
}
