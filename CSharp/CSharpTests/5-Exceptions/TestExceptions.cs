using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    [ExceptionFiltering]
    [TestFixture]
    public class TestExceptions
    {
        CSharp.ExceptionProne sut = new CSharp.ExceptionProne();
        
        [Test]
        public void CheckExceptionIsCatched()
        {
            Assert.DoesNotThrow(()=> sut.SoWeAreCrashing(42));
        }

        [Test]
        public void CheckExceptionIsNotCatched()
        {
           Assert.Throws<CSharp.WeirdException>(()=> sut.SoWeAreCrashing(0));
        }

    }

    public class ExceptionFilteringAttribute : CategoryAttribute
    { }
}
