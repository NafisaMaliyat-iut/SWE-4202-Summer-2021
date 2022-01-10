using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Enrollment_System
{
    internal class Course
    {
        string Title = "";
        string Level = "";
        double Fee = 0;

        public Course()
        { }

        public Course(string title, string level, double fee)
        {
            this.Title = title;
            this.Level = level;
            this.Fee = fee;
        }

        public string GetCourseTitle()
        { return this.Title; }

        public double GetFees()
        { return this.Fee; }

        public string GetCourseLevel()
        { return this.Level; }
    }
}
