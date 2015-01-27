using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTesttrap
    {
        [TestMethod]
        public void TestTrapezoidConstructor()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            Assert.AreEqual(5, trap.Base1);
            Assert.AreEqual(8, trap.Base2);
            Assert.AreEqual(2, trap.Altitude);
            Assert.AreEqual(60, trap.AcuteAngle);
            Assert.AreEqual(120, trap.ObtuseAngle);
            
        }

        [TestMethod]
        public void TestTrapezoidCalculatesAngle()
        {
            Trapezoid trap = new Trapezoid (20, 15, 2);
            Assert.AreEqual((decimal) 38.66, trap.AcuteAngle);
            Assert.AreEqual((decimal) 141.34, trap.ObtuseAngle);
 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorChecksBaseLenghts()
        {
            new Trapezoid(15, 20, 2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorChecksTopLenghts()
        {
            new Trapezoid(15, 20, 2);
        }




        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSanityCheckB2()
        {
            Trapezoid trap = new Trapezoid(0, 2, 3);
         
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSanityCheckB1()
        {
            Trapezoid trap = new Trapezoid(1, 0, 3);
         
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSanityCheckA()
        {
            Trapezoid trap = new Trapezoid(1, 2, 0);
         
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSanityCheckB2negative()
        {
            Trapezoid trap = new Trapezoid(-1, 2, 3);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSanityCheckB1negative()
        {
            Trapezoid trap = new Trapezoid(1, -1, 3);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSanityCheckAnegative()
        {
            Trapezoid trap = new Trapezoid(1, 2, -1);

        }
        [TestMethod]
        public void TestTrapezoidScale100Percent()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            trap.Scale(100);
            Assert.AreEqual(5, trap.Base1);
            Assert.AreEqual(8, trap.Base2);
            Assert.AreEqual(2, trap.Altitude);

        }
        [TestMethod]
        public void TestTrapezoidScale150Percent()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            trap.Scale(150);
            Assert.AreEqual((decimal) 7.5, trap.Base1);
            Assert.AreEqual(12, trap.Base2);
            Assert.AreEqual(3, trap.Altitude);

        }
        [TestMethod]
        public void TestTrapezoidScale200Percent()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            trap.Scale(200);
            Assert.AreEqual(10, trap.Base1);
            Assert.AreEqual(16, trap.Base2);
            Assert.AreEqual(4, trap.Altitude);

        }
        [TestMethod]
        public void TestTrapezoidScale37Percent()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            trap.Scale(37);
            Assert.AreEqual((decimal)1.85, trap.Base1);
            Assert.AreEqual((decimal)2.96, trap.Base2);
            Assert.AreEqual((decimal)0.74, trap.Altitude);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTrapezoidScale0Percent()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            trap.Scale(0);
            
        }
        [TestMethod]
        public void TestTrapezoidScaleUpthenDown()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            trap.Scale(200);
            trap.Scale(50);
            Assert.AreEqual(5, trap.Base1);
            Assert.AreEqual(8, trap.Base2);
            Assert.AreEqual(2, trap.Altitude);

        }
        [TestMethod]
        public void TestTrapezoidSideCount()
        {
            Trapezoid trap = new Trapezoid(4, 6, 4);
            Assert.AreEqual(4, trap.SidesCount);

        }
        [TestMethod]
        public void TestTrapezoidArea()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            Assert.AreEqual(13, trap.Area());

        }
        [TestMethod]
        public void TestTrapezoidAreaBiggerArea()
        {
            Trapezoid trap = new Trapezoid(10, 16, 4);
            Assert.AreEqual(52, trap.Area());

        }
        [TestMethod]
        public void TestTrapezoidPerimeter()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            Assert.AreEqual(16.61, trap.Area());

        }
        //[TestMethod]
        //public void TestTrapezoidBiggerPerimeter()
        //{
        //    Trapezoid trap = new trap(20, 40, 8);
        //    Assert.AreEqual(16.61, trap.Area());

        //}

        [TestMethod]
        public void TestTrapezoidDefaultColors()
        {
            Trapezoid shape = new Trapezoid(10, 20, 4);
            Assert.AreEqual(System.Drawing.Color.Bisque, shape.FillColor);
            Assert.AreEqual(System.Drawing.Color.Tomato, shape.BorderColor);
        }


    }
}
