using CSharp;
// <copyright file="CourseFactory.cs">Copyright ©  2014</copyright>

using System;
using Microsoft.Pex.Framework;

namespace CSharp
{
    /// <summary>A factory for CSharp.Course instances</summary>
    public static partial class CourseFactory
    {
        /// <summary>A factory for CSharp.Course instances</summary>
        [PexFactoryMethod(typeof(Course))]
        public static Course Create(string subject_s, int hours_i, Teacher teacher_teacher)
        {
            Course course = new Course(subject_s, hours_i, teacher_teacher);
            return course;

            // TODO: Edit factory method of Course
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
