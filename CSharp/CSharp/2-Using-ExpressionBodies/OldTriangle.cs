using System;

namespace CSharp
{
    public partial class OldTriangle
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public OldTriangle(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Hypotenuse
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }
    }
}
