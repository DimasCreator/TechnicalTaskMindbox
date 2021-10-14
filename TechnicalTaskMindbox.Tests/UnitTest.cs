using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalTaskMindbox.ShapeLibrary.Shapes;
using System;

namespace TechnicalTaskMindbox.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestCircleArea()
        {
            double radius = 256.2;
            double expected = Math.PI * Math.Pow(radius, 2);
            IShape circle = new Circle(radius);

            //Act
            double result = circle.Area();

            //Assert
            Assert.AreEqual(expected, result, 0.0000001, "Not Corectly");
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            double firstSide = 10;
            double secondSide = 15;
            double thirdSide = 12;
            double semiPerimeter = (firstSide + secondSide + thirdSide) / 2;
            double expected = Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) * (semiPerimeter - secondSide) * (semiPerimeter - thirdSide));

            IShape triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            double result = triangle.Area();

            //Assert
            Assert.AreEqual(expected, result, 0.0000001, "Not Corectly");
        }
    }
}
