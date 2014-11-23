using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace CSharp
{
    /// <summary>
    /// Expression bodies on method-like members
    /// </summary>
    public partial class Triangle
    {
        public Triangle Change(Triangle d) => Change(d.X + X, d.Y + Y);
        public Triangle Change(double dx, double dy) => new Triangle(X + dx, Y + dy);

        public static Triangle operator+(Triangle a, Triangle b) => a.Change(b);

        public void Write() => WriteLine("X=\{X}, Y=\{Y}, Hyp=\{Hypotenuse}");
    }
}
