using CSharp;
// <copyright file="TeacherFactory.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;

namespace CSharp
{
    /// <summary>A factory for CSharp.Teacher instances</summary>
    public static partial class TeacherFactory
    {
        /// <summary>A factory for CSharp.Teacher instances</summary>
        [PexFactoryMethod(typeof(Teacher))]
        public static Teacher Create(string name_s)
        {
            Teacher teacher = new Teacher(name_s);
            return teacher;

            // TODO: Edit factory method of Teacher
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
