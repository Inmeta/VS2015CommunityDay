using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Properties
    {

        public Properties(int y)
        {
            Y = y;
        }

        public int X { get; set; } = 42;
        public DateTime SomeDate { get; } = DateTime.Now;

        public int Y { get; }
    }



}
