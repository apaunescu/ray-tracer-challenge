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
        public static Tuple Add(Tuple a, Tuple b)
        {
            Tuple temp = new Tuple(0, 0, 0, 0);
            temp.X = a.X + b.X;
            temp.Y = a.Y + b.Y;
            temp.Z = a.Z + b.Z;
            temp.W = a.W + b.W;
            return temp;
        }
        public static Tuple Subtract(Tuple a, Tuple b)
        {
            Tuple temp = new Tuple(0, 0, 0, 0);
            temp.X = a.X - b.X;
            temp.Y = a.Y - b.Y;
            temp.Z = a.Z - b.Z;
            temp.W = a.W - b.W;
            return temp;
        }
    }
}
