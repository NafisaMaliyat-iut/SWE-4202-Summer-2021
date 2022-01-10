using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Enrollment_System
{
    internal class Enrollment
    {
        string CourseTitle = "";
        string level = "";
        int RegistrationNumber = 0;
        double Fee = 0;
        string EnrollmentDate = "";

        public Enrollment ()
        { }

        public Enrollment(string title, string level, int RegNo, double fee, string enrollmentDate)
        {
            this.CourseTitle = title;
            this.Fee = fee;
            this.RegistrationNumber = RegNo;
            this.level = level;
            this.EnrollmentDate = enrollmentDate;
        }

        
        public virtual void SetFees(double value)
        {
            this.Fee = value;
        }


        public string GetEnrollmentInfo()
        {
            return Convert.ToString(this.CourseTitle) + "\t" + this.level + "\t     " + Convert.ToString(this.Fee) + "\t" + Convert.ToString(this.EnrollmentDate);
        }
    }
}
 