using ConsoleApp8;

namespace CalulateSquareLibraryTest
{
    [TestClass]
    public class CalculateSquare
    {
        [TestMethod]
        public void CalculateTriangleSquare()
        {
            //Arrange
            var triangle = new Triangle(11,5,8);

            //Act
            double result = triangle.CalculateSquare();

            //Assert
            Assert.AreEqual(18.3303027798, result);
        }

        [TestMethod]
        public void CalculateCircleSquare()
        {
            //Arrange
            var circle = new Circle(10);

            //Act
            double result = circle.CalculateSquare();

            //Assert
            Assert.AreEqual(314.15926535, result);
        }
    }
}