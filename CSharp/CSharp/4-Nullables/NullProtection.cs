using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class CourseSetups
    {

        /// <summary>
        /// The old way of protecting agains nulls
        /// </summary>
       public string GenerateCourseTitle(Course course)
        {
            if (course != null &&
                course.Teacher != null &&
                course.Subject != null &&
                course.Teacher.Name != null)
                return "Course \{course.Subject} taught by \{course.Teacher.Name}";
            return null;
        }



        /// <summary>
        /// The new way of protecting against nulls
        /// </summary>
        public string GenerateCourseTitleNew(Course course)
        {
            var title = "Course \{course?.Subject ?? " which is unknown"} taught by \{course?.Teacher?.Name ?? " no one we know"}";
            return title;
        }


        public void LetsHandleDisposableClasses(IDisposable something)
        {
            something?.Dispose();
        }

        public Course ChangeTeacherOnGivenCourse(Teacher teacher, Course course)
        {
            course?.ChangeTo(teacher);
            return course;
        }


        public bool VerifyTeacherInCourse(Teacher teacher, Course course)
        {
            bool status = teacher?.Name != course?.Teacher?.Name;
            course?.VerifiedChangeTo(teacher);
            return status;
        }




    }

    public class SomeDisposableClass : IDisposable
    {

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).          
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources. 
        // ~SomeDisposableClass() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }



}
