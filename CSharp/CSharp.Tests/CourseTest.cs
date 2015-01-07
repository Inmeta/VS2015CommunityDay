// <copyright file="CourseTest.cs">Copyright ©  2014</copyright>

using System;
using CSharp;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp
{
    [TestClass]
    [PexClass(typeof(Course))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CourseTest
    {
        [PexMethod]
        public void VerifiedChangeTo([PexAssumeUnderTest]Course target, Teacher teacher)
        {
            target.VerifiedChangeTo(teacher);
            // TODO: add assertions to method CourseTest.VerifiedChangeTo(Course, Teacher)
        }

        [PexMethod]
        [PexAllowedException(typeof(Exception))]
        public void ChangeTo([PexAssumeUnderTest]Course target, Teacher teacher)
        {
            target.ChangeTo(teacher);
            // TODO: add assertions to method CourseTest.ChangeTo(Course, Teacher)
        }
    }
}
