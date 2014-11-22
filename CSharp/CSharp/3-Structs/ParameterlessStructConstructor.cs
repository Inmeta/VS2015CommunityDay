using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{

    struct ParameterlessStructConstructor
    {
        public int A { get; private set; }
        public int B { get; private set; }

        public ParameterlessStructConstructor(int a, int b)
        {
            A = a;
            B = b;
        }
        public ParameterlessStructConstructor()
        {
            A = 42;
            B = 24;
        }
    }
}
