using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RayTracerMathTest
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void ATupleWithWEquals1Dot0IsAPoint()
        {
            RayTracerMath.Tuple tuple = new RayTracerMath.Tuple(4.3f, -4.2f, 3.1f, 1.0f);
            Assert.AreEqual(tuple.X, 4.3f);
            Assert.AreEqual(tuple.Y, -4.2f);
            Assert.AreEqual(tuple.Z, 3.1f);
            Assert.AreEqual(tuple.W, 1.0f);

            Assert.AreEqual(tuple.isPoint(), true);
            Assert.AreEqual(tuple.isVector(), false);
        }
    }
}
