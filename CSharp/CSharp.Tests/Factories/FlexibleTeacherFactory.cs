using CSharp;
// <copyright file="FlexibleTeacherFactory.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;

namespace CSharp
{
    /// <summary>A factory for CSharp.FlexibleTeacher instances</summary>
    public static partial class FlexibleTeacherFactory
    {
        /// <summary>A factory for CSharp.FlexibleTeacher instances</summary>
        [PexFactoryMethod(typeof(FlexibleTeacher))]
        public static FlexibleTeacher Create(string name_s)
        {
            FlexibleTeacher flexibleTeacher = new FlexibleTeacher(name_s);
            return flexibleTeacher;

            // TODO: Edit factory method of FlexibleTeacher
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
