using CalculateSquareLibrary.Domain;
namespace CalulateSquareLibrary.Tests
{
    [TestClass]
    public class TriangleTest
    {
        ///// <summary>
        ///// Naming Convention - ClassName_MethodName_ExpectedResult
        ///// </summary>
        //[TestMethod("CreateTriangle_PositiveScenario")]
        //public void Triangle_CalculateSquare_EqualitySuccessful()
        //{
        //    // Arrange
        //    var firstSide = 2;
        //    var secondSide = 1;
        //    var thirdSide = 5;

        //    // Act 
        //    //Circle circle1 = new Circle(radius);
        //    //Circle circle2 = new Circle(radius);

        //    circle1.CalculateSquare();
        //    circle2.CalculateSquare();
        //    // Assert
        //    Assert.AreEqual(circle1, circle2);
        //}

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

            // Assert
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

            // Assert
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
