using CalculateSquareLibrary.Domain;

namespace CalulateSquareLibraryTest
{
    [TestClass]
    public class CalculateSquare
    {
        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [TestMethod("CreateCircle_PositiveScenario")]
        [DataRow(5)]
        public void Circle_CalculateSquare_EqualitySuccessful(int radius)
        {
            // Arrange
            var _radius = radius;

            // Act 
            Circle circle1 = new Circle(_radius);
            Circle circle2 = new Circle(_radius);

            circle1.CalculateSquare();
            circle2.CalculateSquare();
            // Assert
            Assert.AreEqual(circle1, circle2);
        }

        [TestMethod("CreateCircle_NegativeScenario")]
        public void Circle_CalculateSquare_EqualityIsNotSuccessful()
        {
            // Arrange
            var radius = 5;
            var radius2 = 10;

            // Act 
            Circle circle1 = new Circle(radius);
            Circle circle2 = new Circle(radius2);

            circle1.CalculateSquare();
            circle2.CalculateSquare();
            // Assert
            Assert.AreNotEqual(circle1, circle2);
        }

        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod("CreateCircle_NegaitiveScenario")]
        public void FiguresService_CreateCircle_CircleNotCreated()
        {
            // Arrange
            var radius = -1;

            // Act 
            Circle circle = new Circle(radius);
        }

    }
}