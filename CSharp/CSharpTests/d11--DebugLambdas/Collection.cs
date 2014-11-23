using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests.d11__DebugLambdas
{
    public class Collection : List<Person>
    {

    }

    public class Person
    {
        public string Name { get;  } 

        public string City { get; }
        public Person(string name,string city)
        {
            Name = name;
            City = city;
        }

        public List<int> Numbers { get; } = new List<int> { 1,2,3,4,5};
    }
}
