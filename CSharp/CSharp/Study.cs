using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public Teacher Teacher { get; }
        public string Subject { get; }
        public Course(string subject, Teacher teacher)
        {
            Subject = subject;
            Teacher = teacher;
        }
    }
}
