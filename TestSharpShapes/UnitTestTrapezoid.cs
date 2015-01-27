using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace TestSharpShapes
{
    [TestClass]
    public class UnitTesttrap
    {
        [TestMethod]
        public void TestTrapezoidConstructorSetsProperties()
        {
            Trapezoid trapezoid = new Trapezoid(8, 2, 4);
            Assert.AreEqual(8, trapezoid.LongBase);
            Assert.AreEqual(2, trapezoid.ShortBase);
            Assert.AreEqual(4, trapezoid.Height);
        }

        [TestMethod]
        public void TestTrapezoidConstructorSetsProperties2()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 2);
            Assert.AreEqual(20, trapezoid.LongBase);
            Assert.AreEqual(15, trapezoid.ShortBase);
            Assert.AreEqual(2, trapezoid.Height);
        }

        [TestMethod]
        public void TestTrapezoidConstructorCalculatesAngles1()
        {
            Trapezoid trapezoid = new Trapezoid(8, 4, 2);
            Assert.AreEqual(45, trapezoid.AcuteAngle);
            Assert.AreEqual(135, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        public void TestTrapezoidConstructorCalculatesAngles2()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 2);
            Assert.AreEqual((decimal)38.66, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)141.34, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorSanityChecksBaseLengths()
        {
            new Trapezoid(15, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorSanityChecksLongBaseLength()
        {
            new Trapezoid(0, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidTrapezoidCantBeRectangle()
        {
            new Trapezoid(20, 20, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorSanityChecksShortBaseLength()
        {
            new Trapezoid(15, 0, 2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidConstructorSanityChecksHeight()
        {
            new Trapezoid(15, 20, 0);
        }


        
        [TestMethod]
        public void TestTrapezoidConstructor()
        {
            Trapezoid trap = new Trapezoid(5, 8, 2);
            Assert.AreEqual(5, trap.LongBase);
            Assert.AreEqual(8, trap.LongBase);
            Assert.AreEqual(2, trap.Height);
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
        public void TestScaleTrapezoid200Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(200);
            Assert.AreEqual(40, trapezoid.LongBase);
            Assert.AreEqual(30, trapezoid.ShortBase);
            Assert.AreEqual(20, trapezoid.Height);
            Assert.AreEqual((decimal)75.96, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)104.04, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        public void TestScaleTrapezoid100Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(100);
            Assert.AreEqual(20, trapezoid.LongBase);
            Assert.AreEqual(15, trapezoid.ShortBase);
            Assert.AreEqual(10, trapezoid.Height);
            Assert.AreEqual((decimal)75.96, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)104.04, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        public void TestScaleTrapezoid150Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(150);
            Assert.AreEqual(30, trapezoid.LongBase);
            Assert.AreEqual((decimal)22.5, trapezoid.ShortBase);
            Assert.AreEqual(15, trapezoid.Height);
            Assert.AreEqual((decimal)75.96, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)104.04, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        public void TestScaleTrapezoid37Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(37);
            Assert.AreEqual((decimal)7.4, trapezoid.LongBase);
            Assert.AreEqual((decimal)5.55, trapezoid.ShortBase);
            Assert.AreEqual((decimal)3.7, trapezoid.Height);
            Assert.AreEqual((decimal)75.96, trapezoid.AcuteAngle);
            Assert.AreEqual((decimal)104.04, trapezoid.ObtuseAngle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidScaleTo0Percent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TrapezoidScaleToNegativePercent()
        {
            Trapezoid trapezoid = new Trapezoid(20, 15, 10);
            trapezoid.Scale(-10);
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
