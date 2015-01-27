using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestSquares
    {
        [TestMethod]
        public void TestSquareConstructor()
        {
            Square square = new Square(50);
            Assert.AreEqual(50, square.Width);
            Assert.AreEqual(50, square.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksWidth()
        {
            Square square = new Square(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSquareConstructorSanityChecksWidthPositivity()
        {
            Square square = new Square(-1);
        }

        [TestMethod]
        public void TestScaleSquare200Percent()
        {
            Square square = new Square(5);
            square.Scale(200);
            Assert.AreEqual((decimal) 10, square.Height);
            Assert.AreEqual((decimal) 10, square.Width);
            
        }

        [TestMethod]
        public void TestScaleSquare150Percent()
        {
            Square square = new Square(4);
            square.Scale(150);
            Assert.AreEqual((decimal) 6, square.Height);
            Assert.AreEqual((decimal)6, square.Width);
        }

        [TestMethod]
        public void TestScaleSquare100Percent()
        {
            Square square = new Square(2);
            square.Scale(100);
            Assert.AreEqual(2, square.Width);
            Assert.AreEqual(2, square.Height);
            
        }

        [TestMethod]
        public void TestScaleSquare37Percent()
        {
            Square square = new Square(15);
            square.Scale(37);
            Assert.AreEqual((decimal)5.55, square.Width);
            Assert.AreEqual((decimal)5.55, square.Height);
        }

        [TestMethod]
        public void TestScaleSquareUpandDown()
        {
            Square square = new Square(10);
            square.Scale(50);
            square.Scale(200);
            Assert.AreEqual(10, square.Width);
            Assert.AreEqual(10, square.Height);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleSquareTo0Percent()
        {
            Square square = new Square(10);
            square.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestScaleSquareToNegativePercent()
        {
            Square square = new Square(10);
            square.Scale(-5);
        }

        [TestMethod]
        public void TestSidesCount()
        {
            Square square = new Square(4);
            Assert.AreEqual(4, square.SidesCount);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square square = new Square(5);
            Assert.AreEqual(25, square.Area());
        }

        [TestMethod]
        public void TestBiggerSquareArea()
        {
            Square square = new Square(10);
            Assert.AreEqual(100, square.Area());
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            Square square = new Square(2);
            Assert.AreEqual(8, square.Perimeter());
        }

        [TestMethod]
        public void TestBiggerSquarePerimeter()
        {
            Square square = new Square(10);
            Assert.AreEqual(40, square.Perimeter());
        }

        [TestMethod]
        public void TestDefaultColors()
        {
            Square shape = new Square(10);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
        }
    }
}

