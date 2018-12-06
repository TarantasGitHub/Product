using System;
using GeometricFiguresLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometricFiguresUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CirclePerimeterTest()
        {
            double r = 152;
            Circle circle = new Circle(r);
            Assert.AreEqual(2 * Math.PI * r, circle.Perimeter());
        }

        [TestMethod]
        public void CircleSquareTest()
        {
            double r = 152;
            Circle circle = new Circle(r);
            Assert.AreEqual(Math.PI * r * r, circle.Square());
        }

        [TestMethod]
        public void TrianglePerimeterTest()
        {
            double a = 15, b = 15, c = 15;
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(a + b + c, triangle.Perimeter());
        }

        [TestMethod]
        public void TriangleSquareTest()
        {
            double a = 15, b = 15, c = 15;
            Triangle triangle = new Triangle(a, b, c);
            double p = (a + b + c) / 2;
            Assert.AreEqual(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), triangle.Square());
        }

        [TestMethod]
        public void TriangleIsRightTest1()
        {
            double a = 3, b = 4, c = 5;
            Triangle triangle = new Triangle(a, b, c);            
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TriangleIsRightTest2()
        {
            double a = 3, b = 3, c = 5;
            Triangle triangle = new Triangle(a, b, c);
            Assert.IsFalse(triangle.IsRightTriangle());
        }
    }
}
