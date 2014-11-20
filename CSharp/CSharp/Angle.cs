using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace CSharp
{
    public class Angle
    {
        public double X { get; }
        public double Y { get; }

        public Angle(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Hypotenuse => Sqrt(X * X + Y * Y);
    }
}
