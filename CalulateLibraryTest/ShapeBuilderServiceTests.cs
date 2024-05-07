using CalculateSquareLibrary.Domain;
using CalculateSquareLibrary.Domain.Services;

namespace CalulateSquareLibrary.Tests
{
    [TestClass]
    public class ShapeBuilderServiceTests
    {
        /// <summary>
        /// Naming Convention - ClassName_MethodName_ExpectedResult
        /// </summary>
        [TestMethod("CreateTriangle_PositiveScenario")]
        public void ShapeBuilderService_CalculateSquare_Upcast()
        {
            // Arrange
            var firstSide = 3;
            var secondSide = 4;
            var thirdSide = 5;

            // Act 
            Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
            ShapeBuilderService service = new ShapeBuilderService(triangle);

            // Assert
            var shapeType = service.WhatIsIt();
            Assert.AreEqual(shapeType, nameof(Triangle));  
        }
    }
}
