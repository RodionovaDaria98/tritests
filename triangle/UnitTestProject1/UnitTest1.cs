using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using triangleslides;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {


            Assert.AreEqual(TriangleType.Error,
                            Triangle.GettypofTriangle(4, 0, 4),
                            "GetTriangleType(4, 0, 4) did not return Error");

            Assert.AreEqual(TriangleType.Error,
                            Triangle.GettypofTriangle(1, 4, 2),
                            "GetTriangleType(1, 4, 2) did not return Error");

            Assert.AreEqual(TriangleType.RightTriangle,
                            Triangle.GettypofTriangle(1, 1, Math.Sqrt(2)),
                            "GetTriangleType(1, 1, Math.Sqrt(2)) did not return RightTriangle");

            Assert.AreEqual(TriangleType.OxygonTriangle,
                            Triangle.GettypofTriangle(4, 1, 4),
                            "GetTriangleType(4, 1, 4) did not return OxygonTriangle");

            Assert.AreEqual(TriangleType.ObtuseTriangle,
                            Triangle.GettypofTriangle(655, 650, 50),
                            "GetTriangleType(655, 650, 50) did not return ObtuseTriangle");
        }
    }
}
