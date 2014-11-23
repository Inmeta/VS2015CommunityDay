using CSharp._2_Using_ExpressionBodies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._7_Dictionary
{
    public class ComplexDictionary
    {

        Dictionary<int, Customer> Catalog { get; }  = new Dictionary<int, Customer>()
        {
            [1] = new Customer("Arne",1),
            [2] = new Customer("Per",2),
            [3] = new Customer("Mads",3)
        };

        public Customer FindByShortNumber(int no) => Catalog[no];
    }
}
