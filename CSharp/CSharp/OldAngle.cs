using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharp
{
    public class OldAngle
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public OldAngle(double x, double y)
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
