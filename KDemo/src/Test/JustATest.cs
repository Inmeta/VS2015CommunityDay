using System;
using Xunit;

namespace Test
{
    public class JustATest
    {
        [Fact]
        public void ThatAddWorks()
        {
            var sut = new KDemo.JustALibrary();

            var res = sut.LetUsAdd(42, 42);

            Assert.Equal(84, res);
        }

    }
}
