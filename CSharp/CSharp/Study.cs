using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharp
{
    public class Teacher
    {
        public string Name { get; }

        public Teacher(string name)
        {
            Name = name;
        }
    }

    public class Course
    {
        public Teacher Teacher { get; private set; }
        public string Subject { get; }
        public Course(string subject, Teacher teacher)
        {
            Subject = subject;
            Teacher = teacher;
        }

        public void ChangeTo(Teacher teacher)
        {
            Teacher = teacher;
        }

        public void VerifiedChangeTo(Teacher teacher)
        {
            if (Teacher!=null)
            {
                Thread.Sleep(2000);
                
            }
            Teacher = teacher;
        }
    }
}
