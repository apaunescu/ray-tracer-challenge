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
        [TestMethod]
        public void ATupleWithWEquals0Dot0IsAVector()
        {
            RayTracerMath.Tuple tuple = new RayTracerMath.Tuple(4.3f, -4.2f, 3.1f, 0.0f);
            Assert.AreEqual(tuple.X, 4.3f);
            Assert.AreEqual(tuple.Y, -4.2f);
            Assert.AreEqual(tuple.Z, 3.1f);
            Assert.AreEqual(tuple.W, 0.0f);

            Assert.AreEqual(tuple.isPoint(), false);
            Assert.AreEqual(tuple.isVector(), true);
        }
        [TestMethod]
        public void AddingTwoTuples()
        {
            RayTracerMath.Tuple tuple1 = new RayTracerMath.Tuple(3, -2, 5, 1);
            RayTracerMath.Tuple tuple2 = new RayTracerMath.Tuple(-2, 3, 1, 0);
            System.Console.WriteLine(RayTracerMath.Tuple.Add(tuple1, tuple2));
            Assert.AreEqual(RayTracerMath.Tuple.Add(tuple1, tuple2), new RayTracerMath.Tuple(1, 1, 6, 1));
        }
        [TestMethod]
        public void SubtractingTwoPoints()
        {
            RayTracerMath.Tuple p1 = new RayTracerMath.Tuple(3, 2, 1, 1);
            RayTracerMath.Tuple p2 = new RayTracerMath.Tuple(5, 6, 7, 1);
            Assert.AreEqual(p1.X - p2.X, -2);
            Assert.AreEqual(p1.Y - p2.Y, -4);
            Assert.AreEqual(p1.Z - p2.Z, -6);
            Assert.AreEqual(p1.W - p2.W, 0);
        }
        [TestMethod]
        public void SubtractingAVectorFromAPoint()
        {
            RayTracerMath.Tuple point = new RayTracerMath.Tuple(3, 2, 1, 1);
            RayTracerMath.Tuple vector = new RayTracerMath.Tuple(5, 6, 7, 0);
            Assert.AreEqual(point.X - vector.X, -2);
            Assert.AreEqual(point.Y - vector.Y,-4);
            Assert.AreEqual(point.Z - vector.Z, -6);
            Assert.AreEqual(point.W + vector.W, 1);
        }
        [TestMethod]
        public void SubtractingTwoVectors()
        {
            RayTracerMath.Tuple v1 = new RayTracerMath.Tuple(3, 2, 1, 0);
            RayTracerMath.Tuple v2 = new RayTracerMath.Tuple(5, 6, 7, 0);
            Assert.AreEqual(v1.X - v2.X, -2);
            Assert.AreEqual(v1.Y - v2.Y, -4);
            Assert.AreEqual(v1.Z - v2.Z, -6);
            Assert.AreEqual(v1.W + v2.W, 0);
        }
        [TestMethod]
        public void SubtractingAVectorFromTheZeroVector()
        {
            RayTracerMath.Tuple zeroVector = new RayTracerMath.Tuple(0, 0, 0, 0);
            RayTracerMath.Tuple vector = new RayTracerMath.Tuple(1, -2, 3, 0);
            Assert.AreEqual(zeroVector.X - vector.X, -1);
            Assert.AreEqual(zeroVector.Y - vector.Y, 2);
            Assert.AreEqual(zeroVector.Z - vector.Z, -3);
            Assert.AreEqual(zeroVector.W + vector.W, 0);
        }
    }
}
