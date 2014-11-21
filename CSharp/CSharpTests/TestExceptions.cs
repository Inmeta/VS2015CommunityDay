using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    [TestFixture]
    public class TestExceptions
    {
        [Test]
        public void CheckExceptionIsCatched()
        {
            var sut = new CSharp.ExceptionProne();

            sut.SoWeAreCrashing(42);

            Assert.IsTrue(true);
        }

        [ExpectedException(typeof(CSharp.WeirdException))]
        [Test]
        public void CheckExceptionIsNotCatched()
        {
            var sut = new CSharp.ExceptionProne();

            sut.SoWeAreCrashing(0);

            Assert.IsTrue(true);
        }

    }
}
