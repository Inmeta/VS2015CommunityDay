using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharpTests
{
    [TestFixture]
    public class TestNameOf
    {
        [Test]
        public void NameOfParameter()
        {
            var sut = new CSharp.NameOfParameter();

            Assert.Throws(typeof(ArgumentNullException),()=> sut.WhenWeCanUseIt(null));
        }

    }
}
