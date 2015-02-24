using System;
using static System.Math;

namespace CSharp
{
    public partial class Triangle
    {
        public double X { get; }
        public double Y { get; }

        public Triangle(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Hypotenuse => Sqrt(X * X + Y * Y);
    }
}
