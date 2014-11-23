using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests.d11__DebugLambdas
{
    [TestFixture]
    public class LookupTest
    {
        [Test]
        public void CheckDict()
        {
            var sut = new Collection
            {
                new Person("Per","Oslo"),new Person("Arne","Bergen"),new Person("Trond","Horten"),new Person("Einar","Sandefjord"),new Person("Martin","Glasgow")
            };

            var res = sut.Where(p => p.City == "Bergen").Single().Numbers.Aggregate((x,sum) => sum+x);





        }
    }




}
