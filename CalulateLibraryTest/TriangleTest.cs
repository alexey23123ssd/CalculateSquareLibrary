using CalculateSquareLibrary.Domain;
namespace CalulateSquareLibrary.Tests
{
    [TestClass]
    public class TriangleTest
    {
        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [TestMethod("CreateTriangle_PositiveScenario")]
        [DataRow(2,1,3)]
        public void Triangle_CalculateSquare_EqualitySuccessful(double firstSide, double secondSide, double thirdSide)
        {
            // Arrange
            var _firstSide = firstSide;
            var _secondSide = secondSide;
            var _thirdSide = thirdSide;

            // Act 
            Triangle triangle1 = new Triangle(_firstSide,_secondSide,_thirdSide);
            Triangle triangle2 = new Triangle(_firstSide, _secondSide, _thirdSide);

            triangle1.CalculateSquare();
            triangle2.CalculateSquare();
            // Assert
            Assert.AreEqual(triangle1, triangle2);
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod("CreateTriangle_NegativeScenario")]
        public void Triangle_CalculateSquare_EqualityIsNotSuccessful()
        {
            // Arrange
            var firstSide = -1;
            var secondSide = 1;
            var thirdSide = 5;

            // Act 
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            // Assert - throw new ArgumentException
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod("CreateTriangle_NegativeScenario")]
        public void Triangle_CalculateSquare_EqualityIsNotSuccessfulL()
        {
            // Arrange
            var firstSide = 15;
            var secondSide = 1;
            var thirdSide = 5;

            // Act 
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            // Assert - throw new ArgumentException
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [TestMethod("CreateTriangle_NegativeScenario")]
        public void Triangle_CalculateSquare_EqualityIsNotSuccessfulJL()
        {
            // Arrange
            var firstSide = 3;
            var secondSide = 4;
            var thirdSide = 5;

            // Act 
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(triangle._isRectangular, true);
        }
    }
}
