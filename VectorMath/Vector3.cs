using System;
using System.Collections.Generic;
using System.Text;

namespace VectorMath
{
    public class Vector3
    {
        double X;
        double Y;
        double Z;

        public override string ToString()
        {
            return $"<{this.X}, {this.Y}, {this.Z}>";
        }

        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // Vector Addition
        public static Vector3 Add(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public Vector3 Add(Vector3 other)
        {
            return new Vector3(this.X + other.X, this.Y + other.Y, this.Z + other.Z);
        }

        /// <summary>
        /// No return type
        /// </summary>
        /// <param name="other"></param>
        public void AddInPlace(Vector3 other)
        {
            this.X += other.X;
            this.Y += other.Y;
            this.Z += other.Z;
        }

        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        // Vector Subtraction
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        // Vector Scaling 
        public static Vector3 operator *(double s, Vector3 v)
        {
            return new Vector3(s * v.X, s * v.Y, s * v.Z);
        }
        public static Vector3 operator *(Vector3 v, double s)
        {
            return new Vector3(s * v.X, s * v.Y, s * v.Z);
        }

        // Vector Comparison
        public static bool operator ==(Vector3 a, Vector3 b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        public static bool operator !=(Vector3 a, Vector3 b)
        {
            return a.X != b.X && a.Y != b.Y && a.Z != b.Z;
        }

        public static Vector3 operator ++(Vector3 a)
        {
            return new Vector3(a.X++, a.Y++, a.Z++);
        }

        public static double operator ~(Vector3 a)
        {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z + a.Z);
        }

    }
}
