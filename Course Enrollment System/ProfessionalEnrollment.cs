using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Enrollment_System
{
    internal class ProfessionalEnrollment: Enrollment
    {
        public override void SetFees(double value)
        {
            base.SetFees(1.1 * value);
        }

        public ProfessionalEnrollment()
        { }

        public ProfessionalEnrollment(string CourseTitle, string Level, int registrationNumber, double fee, string enrollmentDate) : base(CourseTitle, Level, registrationNumber, fee, enrollmentDate)
        { }
    }
}
