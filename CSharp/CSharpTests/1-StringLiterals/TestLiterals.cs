﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharp;

namespace CSharpTests
{
    [StringLiterals]
    [TestFixture]
    public class TestLiterals
    {
        [Test]
        public void CheckBook()
        {
            var book = new StringLiterals();

            var res = book.WhatIsTheMessage;

            Assert.That(res.Length, Is.GreaterThan(19));
            Assert.That(res.Contains("42"), "Interpolation doesn't work yet");
            Assert.That(res.Contains("Douglas"), "Interpolation doesn't work yet");
            Assert.That(res.Contains("Adams"), "Interpolation doesn't work yet");
            Assert.That(res.Contains("galaxy"), "Interpolation doesn't work yet");
        }
    }

    public class StringLiteralsAttribute : CategoryAttribute
    {    }
}
