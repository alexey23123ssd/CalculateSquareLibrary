using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

namespace ConsoleApp8
{
    public class Triangle : GeometricShape
    {
        private const string lessThanOrEqualToZeroMessage = "the values cannot be less than or equal to zero";
        private const string theLengthsOfTheSidesMessage = "the length of one side must not exceed the sum of the other two sides";
        private double _firstSide { get; set; }
        private double _secondSide { get; set; }
        private double _thirdSide { get; set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException(lessThanOrEqualToZeroMessage);
            }
            if (firstSide > secondSide + thirdSide || secondSide > firstSide + thirdSide || thirdSide > firstSide + secondSide)
            {
                throw new ArgumentException(theLengthsOfTheSidesMessage);
            }
            if (Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2) || Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2) || Math.Pow(thirdSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2))
            {
                Console.WriteLine("rectangular triangle");
            }
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }
       
        public override double CalculateSquare()
        {
            var halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
            var square = Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) * (halfPerimeter - _secondSide) * (halfPerimeter - _thirdSide));
            return square;
        }
    }
}
