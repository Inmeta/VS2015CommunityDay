using System;
using Xunit;

namespace K_App
{
    public class Application
    {
        public Application()
        {

        }

        public int Add(int x, int y) => x + y;

    }


    public class TestApp
    {
        [Fact]
        public void KCheckAdd()
        {

            var app = new Application();

            var res = app.Add(2, 2);

            Assert.True(res==4);

        }

    }


}
