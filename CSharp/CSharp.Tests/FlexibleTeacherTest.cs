// <copyright file="FlexibleTeacherTest.cs">Copyright ©  2014</copyright>

using System;
using CSharp;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp
{
    [TestClass]
    [PexClass(typeof(FlexibleTeacher))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FlexibleTeacherTest
    {
        [PexMethod]
        [PexAllowedException(typeof(AssertFailedException))]
        public int PaymentDue([PexAssumeUnderTest]FlexibleTeacher target, int hours)
        {
            Assert.IsNotNull(target);
            Assert.IsNotNull(target.Name);
            Assert.IsTrue(target.Name.Trim().Length>3);
            int result = target.PaymentDue(hours);
            return result;
            // TODO: add assertions to method FlexibleTeacherTest.PaymentDue(FlexibleTeacher, Int32)
        }
    }
}
