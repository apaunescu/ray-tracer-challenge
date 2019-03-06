using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerMath
{
    public class Tuple
    {
        private const float EPSILON = 0.00001f;

        public Tuple(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
        public float X;
        public float Y;
        public float Z;
        public float W;

        public bool isPoint()
        {
            return this.W == 1.0f;
        }

        public bool isVector()
        {
            return this.W == 0.0f;
        }

        public bool isEqual(Tuple compare)
        {
            if (isFloatEqual(this.X, compare.X) && 
                isFloatEqual(this.Y, compare.Y) &&
                isFloatEqual(this.Z, compare.Z) &&
                isFloatEqual(this.W, compare.W))
            {
                return true;
            }
            return false;
        }

        private bool isFloatEqual(float x1, float x2)
        {
            if (Math.Abs(x1 - x2) < EPSILON)
            {
                return true;
            }
            return false;
        }

        public static Tuple Point(float x, float y, float z)
        {
            return new Tuple(x, y, z, 1.0f);
        }

        public static Tuple Vector(float x, float y, float z)
        {
            return new Tuple(x, y, z, 0.0f);
        }
    }


}
