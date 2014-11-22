using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class CodeWithIssues
    {
        public CodeWithIssues()
        {
            try
            {
                
            }
            catch 
            {


                
            }
        }


        public int Ternary(string s)
        {
            if (s == null)
                return 1;
            else
                return 2;
        }

        public X ObjectInitializer()
        {
            var x = new X();
            x.A = 4;
            x.B = 2;
            return x;
        }




    }


    public class X
    {

        public int A { get; set; }
        public int B { get; set; }

    }
}
