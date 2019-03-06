using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RayTracerMathTest
{
    [TestClass]
    public class TupleTests
    {
        [TestMethod]
        public void ATupleWithWEquals1IsAPoint()
        {
            RayTracerMath.Tuple tuple = new RayTracerMath.Tuple(4.3f, -4.2f, 3.1f, 1.0f);
            Assert.AreEqual(tuple.X, 4.3f);
            Assert.AreEqual(tuple.Y, -4.2f);
            Assert.AreEqual(tuple.Z, 3.1f);
            Assert.AreEqual(tuple.W, 1.0f);

            Assert.AreEqual(tuple.isPoint(), true);
            Assert.AreEqual(tuple.isVector(), false);
        }

        [TestMethod]
        public void PointFuncCreatesTuplesWithWEqual1()
        {
            RayTracerMath.Tuple tuple = RayTracerMath.Tuple.Point(4, -4, 3);
            Assert.AreEqual(tuple.W, 1.0f);

        }

        [TestMethod]
        public void VectorFuncCreatesTuplesWithWEqual0()
        {
            RayTracerMath.Tuple tuple = RayTracerMath.Tuple.Vector(4, -4, 3);
            Assert.AreEqual(tuple.W, 0.0f);
        }

        [TestMethod]
        public void IsEqualIsTrueWhenComparingTwoTuplesWithSameValue()
        {
            RayTracerMath.Tuple tuple1 = RayTracerMath.Tuple.Vector(4, -4, 3);
            RayTracerMath.Tuple tuple2 = RayTracerMath.Tuple.Vector(4, -4, 3);

            bool isEqual = tuple1.isEqual(tuple2);
            Assert.AreEqual(isEqual, true);
        }
    }
}
