using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace CSharp
{
    public class NewClass
    {
        public int X { get; set; } = 42;
        public DateTime SomeDate { get; } = DateTime.Now;
        public int Y { get; }
        public IEnumerable<int> ListOfInts { get; } = new List<int>();
        public NewClass(int y)
        {
            Y = y;
        }
        public string Information => "On \{SomeDate} there is \{ListOfInts.Count()} elements";
        
    }

   
}
