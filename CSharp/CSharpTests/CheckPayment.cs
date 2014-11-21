using CSharp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTests
{
    [TestFixture]
    public class CheckCoursesPayments
    {
        List<Course> Courses { get; } = new List<Course>();

        [SetUp]
        public void Init()
        {
            Courses.Add(new Course("ALM", 3,new Teacher("Martin")));
            Courses.Add(new Course("Scrum PSD", 8,new Teacher("Martin")));
            Courses.Add(new Course("Scrum PSD2",10, new Teacher("Martin")));
            Courses.Add(new Course("C# 1",5, new Teacher("Einar")));
            Courses.Add(new Course("Scrum Top Notch", 16, new SpecialTeacher("Martin")));
            Courses.Add(new Course("ALM 3", 4, new Teacher("Martin")));
            Courses.Add(new Course("VS2015", 5, new SpecialTeacher("Terje")));
            Courses.Add(new Course("ALM beginner", 2,new Teacher("Martin")));
            Courses.Add(new Course("Scrum beginner", 3, new Teacher("Martin")));
            Courses.Add(new Course("ALM Extra", 10, new Teacher("Martin")));

        }


        [Test]
        public void VerifyPaymentToTeachers()
        {
            int cost = 0;
            foreach(var course in Courses)
            {
                cost += course.Due();
            }
            Assert.That(cost, Is.AtMost(1200),"This is far beyond our budgets!");
        }
    }
}
