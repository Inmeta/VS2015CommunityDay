using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp;

namespace CSharpTests
{
    [TestFixture]
    public class TestNullStuff
    {

        public List<Course> Courses { get; } = new List<Course>();
        public void SetupCourse()
        {
            var teacher = new Teacher("Martin");
            var course = new Course("ALM", teacher);
            Courses.Add(course);
            Courses.Add(new Course("Driving", null));
            var teacher2 = new Teacher(null);
            Courses.Add(new Course("Walking", teacher2));
            Courses.Add(null);
        }

        [TestCase(0,true)]
        [TestCase(1,false)]
        [TestCase(2,false)]
        [TestCase(3,false)]
        public void CheckNullOldWay(int coursenumber,bool ok)
        {
            SetupCourse();
            var sut = new CourseSetups();

            bool res = false;
            var course = Courses[coursenumber];
            if (course!=null)
                res = sut.GenerateCourseTitle(course)!=null;

            Assert.IsTrue(res==ok);

        }


        [TestCase(0, true)]
        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        public void CheckNullNewWay(int coursenumber,bool ok)
        {
            var sut = new CourseSetups();
            SetupCourse();
            var course = Courses[coursenumber];
            bool res = sut.GenerateCourseTitleNew(course)!=null;
            Assert.IsTrue(res==ok);
                       
        }

        [Test]
        public void CheckDispose()
        {
            var sut = new CourseSetups();
            var disp = new SomeDisposableClass();
            sut.LetsHandleDisposableClasses(disp);

            sut.LetsHandleDisposableClasses(null);

            Assert.IsTrue(true);

        }

        [Test]
        public void CheckChangingTeacher()
        {
            var sut = new CourseSetups();

            var teacher = new Teacher("Einar");

            var course = new Course("ASP.NET 5",null);

            course = sut.FixupAllThings(teacher, course);
            Assert.That(course.Teacher.Name == "Einar");

            course = sut.FixupAllThings(teacher, null);
            Assert.That(course==null);


        }


        [Test]
        public void CheckChangingTeacherVerified()
        {
            var sut = new CourseSetups();

            var teacher = new Teacher("Einar");

            var course = new Course("ASP.NET 5", null);
            sut.VerifyTeacherInCourse(teacher, course);
            Assert.That(course.Teacher.Name == "Einar");

            var teacher2 = new Teacher("Lars");
            sut.VerifyTeacherInCourse(teacher2, course);
            Assert.That(course.Teacher.Name == "Lars");


        }

    }
}
