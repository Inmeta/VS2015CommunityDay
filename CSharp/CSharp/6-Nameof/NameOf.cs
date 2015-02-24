using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class NameOfParameter
    {
        public void WhenWeCanUseIt(string message)
        {
            if (message == null)
            {
                var s = $"Parameter {nameof(message)} of method {nameof(WhenWeCanUseIt)} in class {typeof(NameOfParameter)} is null";
                throw new ArgumentNullException(s);
            }
        }

        
    }
}
