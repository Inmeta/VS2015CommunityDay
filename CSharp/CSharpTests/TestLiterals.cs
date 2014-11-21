using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharp;

namespace CSharpTests
{
    [TestFixture]
    public class TestLiterals
    {
        [Test]
        public void CheckLiterals()
        {
            var book = new StringLiterals();

            var res = book.WhatIsTheMessage;

            Assert.That(res.Length, Is.GreaterThan(19));
            Assert.That(res.Contains("42"),"Interpolation doesn't work yet");
        }
    }
}
