using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Console;

namespace CSharp
{
    class DeclarationExpressions
    {
        public int ConvertToIntTheOldWay(string withSomeNumber)
        {
            int number;
            if (int.TryParse(withSomeNumber,out number))
            {
                return number;
                
            }
            WriteLine("Boom");
            return -1;
        }

        public int ConvertToInt(string withSomeNumber)
        {
            if (int.TryParse(withSomeNumber, out int number))
            {
                return number; 
            }
            WriteLine("Boom");
            return -1;
        }
    }
}
