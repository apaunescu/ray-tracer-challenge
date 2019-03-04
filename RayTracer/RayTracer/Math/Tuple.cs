using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracerMath
{
    public class Tuple
    {
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
