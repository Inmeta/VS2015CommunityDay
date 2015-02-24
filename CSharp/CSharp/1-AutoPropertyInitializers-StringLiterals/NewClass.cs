using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp
{
    public class NewClass
    {
        public int X { get; set; } = 42;
        public DateTime SomeDate { get; } = DateTime.Now;
        public int Y { get; }
        public IEnumerable<int> ListOfInts { get; } = new List<int> { 2, 3, 4, 5, 6 };
        public NewClass(int y)
        {
            Y = y;
        }
        public string Information => $"On {SomeDate} there is {ListOfInts.Count()} elements";
        
    }

   
}
