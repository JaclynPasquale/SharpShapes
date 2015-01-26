using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTestRectangles
    {
        [TestMethod]
        public void TestRectangleConstructor()
        {
            Rectangle rectangle = new Rectangle(40, 50);
            Assert.AreEqual(40, rectangle.Width);
            Assert.AreEqual(50, rectangle.Height);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleConstructorSanityChecksWidth()
        {
            Rectangle rectangle = new Rectangle(0, 50);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleConstructorSanityChecksHeight()
        {
            Rectangle rectangle = new Rectangle(50, 0);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleConstructorSanityChecksWidthPositive()
        {
            Rectangle rectangle = new Rectangle(0, 50);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRectangleConstructorSanityChecksHeightPositive()
        {
            Rectangle rectangle = new Rectangle(50, 0);
            
        }
    }
}
