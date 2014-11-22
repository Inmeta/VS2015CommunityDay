using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class OldClass
    {
        public int X { get; set; }
        public DateTime SomeDate { get; private set; }
        public int Y { get; private set; }
        public IEnumerable<int> ListOfInts { get; private set; }
        public OldClass(int y)
        {
            X = 42;
            Y = y;
            ListOfInts = new List<int>();
            SomeDate = DateTime.Now;
        }
        public string Information
        {
            get
            {
                return string.Format("On {0} there is {1} elements", SomeDate, ListOfInts.Count());
            }
        }
    }
}
