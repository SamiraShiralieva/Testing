using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void RightTriangle()
        {
            Assert.AreEqual(true, UnitTests.Triangle.TriangleSides(5, 7, 6));
        }

        [TestMethod]
        public void NegativeSides()
        {
            Assert.AreEqual(false, UnitTests.Triangle.TriangleSides(-1, -2, -3));
        }

        [TestMethod]
        public void ZeroSides()
        {
            Assert.AreEqual(false, UnitTests.Triangle.TriangleSides(0, 0, 0));
        }

        [TestMethod]
        public void StringsSides()
        {
            Assert.AreEqual(true, UnitTests.Triangle.TriangleSides(Convert.ToDouble("5,76"), Convert.ToDouble("8,14"), Convert.ToDouble("6,93")));
        }

        [TestMethod]
        public void DoubleSides()
        {
            Assert.AreEqual(true, UnitTests.Triangle.TriangleSides(5.76, 10.3, 7.92));
        }

        [TestMethod]
        public void DoubleAndIntSides()
        {
            Assert.AreEqual(true, UnitTests.Triangle.TriangleSides(Convert.ToDouble(5), 9.7, 6.743));
        }

        [TestMethod]
        public void StringAndDoubleSides()
        {
            Assert.AreEqual(true, UnitTests.Triangle.TriangleSides(Convert.ToDouble("4,57"), 12.5, 9.63));
        }

        [TestMethod]
        public void MaxDoubleSides()
        {
            Assert.AreEqual(true, UnitTests.Triangle.TriangleSides(double.MaxValue, double.MaxValue, double.MaxValue));
        }

        [TestMethod]
        public void MinDoubleSides()
        {
            Assert.AreEqual(false, UnitTests.Triangle.TriangleSides(double.MinValue, double.MinValue, double.MinValue));
        }

        [TestMethod]
        public void CheckSides()
        {
            Assert.AreEqual(false, UnitTests.Triangle.TriangleSides(5, 15, 10));
        }
    }
}
