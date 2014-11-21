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

        public virtual int HourlyRate { get; } = 1;

        public int PaymentDue(int hours)
        {
            return hours * HourlyRate;
        }
        
    }

    public class Course
    {
        public Teacher Teacher { get; private set; }
        public string Subject { get; }

        public int Hours { get; }
        public Course(string subject, int hours, Teacher teacher)
        {
            Subject = subject;
            Teacher = teacher;
            Hours = hours;
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

        public int Due()
        {
            return Hours * Teacher.HourlyRate;
        }

    }


    public class SpecialTeacher : Teacher
    {
        public override int HourlyRate { get; } = 50;

        public SpecialTeacher(string name) : base(name)
        {

        }  
    }
}
