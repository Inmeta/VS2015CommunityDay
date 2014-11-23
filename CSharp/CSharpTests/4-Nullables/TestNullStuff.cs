using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp;

namespace CSharpTests
{
    [Nullables]
    [TestFixture]
    public class TestNullStuff
    {

        public List<Course> Courses { get; } = new List<Course>();
        CourseSetups courseManager;

        [SetUp]
        public void SetupCourse()
        {
            courseManager = new CourseSetups();

            Courses.Add(new Course("ALM", 1, new Teacher("Martin")));
            Courses.Add(new Course("Driving",1, null));
            Courses.Add(new Course("Walking",1, new Teacher(null)));
            Courses.Add(null);
        }

        [TestCase(0,true)]
        [TestCase(1,false)]
        [TestCase(2,false)]
        [TestCase(3,false)]
        public void CheckNullOldWay(int coursenumber,bool ok)
        {
            
            bool res = false;
            var course = Courses[coursenumber];
            if (course!=null)
                res = courseManager.GenerateCourseTitle(course)!=null;

            Assert.IsTrue(res==ok);

        }


        [TestCase(0, true)]
        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        public void CheckNullNewWay(int coursenumber,bool ok)
        {
            var course = Courses[coursenumber];
            bool res = courseManager.GenerateCourseTitleNew(course)!=null;
            Assert.IsTrue(res==ok);
                       
        }

        [Test]
        public void CheckDispose()
        {
            var disp = new SomeDisposableClass();
            courseManager.LetsHandleDisposableClasses(disp);

            courseManager.LetsHandleDisposableClasses(null);

            Assert.IsTrue(true);

        }

        [Test]
        public void CheckChangingTeacher()
        {
            
            var teacher = new Teacher("Einar");

            var course = new Course("ASP.NET 5",1,null);

            course = courseManager.ChangeTeacherOnGivenCourse(teacher, course);
            Assert.That(course.Teacher.Name == "Einar");

            course = courseManager.ChangeTeacherOnGivenCourse(teacher, null);
            Assert.That(course==null);


        }


        [Test]
        public void CheckChangingTeacherVerified()
        {
            var teacher = new Teacher("Einar");

            var course = new Course("ASP.NET 5",1, null);
            courseManager.VerifyTeacherInCourse(teacher, course);
            Assert.That(course.Teacher.Name == "Einar");

            var teacher2 = new Teacher("Lars");
            courseManager.VerifyTeacherInCourse(teacher2, course);
            Assert.That(course.Teacher.Name == "Lars");


        }

    }


    public class NullablesAttribute : CategoryAttribute
    { }
}
