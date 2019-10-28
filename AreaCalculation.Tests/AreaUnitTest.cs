using AreaCalculation.Interfaces;
using AreaCalculation.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculation.Tests
{
    [TestClass]
    public class AreaUnitTest
    {
        private IAreaCalculationService sut;
        private Triangle triangle;
        private Circle circle;

        [TestInitialize]
        public void Setup()
        {
            sut = new AreaCalculationService();
            triangle = new Triangle();
            circle = new Circle();
        }

        [TestMethod]
        public void CircleAreaIsCorrect()
        {
            circle.Radius = 2;
            double correctArea = Math.PI * Math.Pow(2, 2);
            Assert.AreEqual(correctArea, sut.CalculateArea(circle));
        }

        [TestMethod]
        public void TriangleAreaIsCorrect()
        {
            triangle.SideA = 3;
            triangle.SideB = 4;
            triangle.SideC = 5;

            double correctArea = 6;            
            Assert.AreEqual(correctArea, sut.CalculateArea(triangle));
        }

        [TestMethod]
        public void RightTriangleIsRight()
        {
            triangle.SideA = 3;
            triangle.SideB = 4;
            triangle.SideC = 5;

            Assert.AreEqual(true, triangle.IsRightTriangle());
        }

        [TestMethod]
        public void NotRightTriangleIsNotRight()
        {
            triangle.SideA = 3;
            triangle.SideB = 4;
            triangle.SideC = 6;

            Assert.AreEqual(false, triangle.IsRightTriangle());
        }

        [TestMethod]
        public void NotInitedTriangleHaveZeroArea()
        {
            Assert.AreEqual(0, sut.CalculateArea(triangle));
        }

        [TestMethod]
        public void NotInitedCircleHaveZeroArea()
        {
            Assert.AreEqual(0, sut.CalculateArea(circle));
        }

        [TestMethod]
        public void NotInitedTriangleIsNotRight()
        {
            Assert.AreEqual(false, triangle.IsRightTriangle());
        }
    }
}
