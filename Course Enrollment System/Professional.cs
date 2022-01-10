using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Enrollment_System
{
    internal class Professional : Participant
    {
        string OfficeAddress = "";
        string OrganizationName = "";

        public List <ProfessionalEnrollment> ProfessionalEnrollmentList = new List<ProfessionalEnrollment> ();

        public Professional (string Name, int RegNo, string ContactNumber, string Email, string Level, string OrganizationAddress, string OrganizationName) : base(Name, RegNo, ContactNumber, Email, Level)
        {
            this.OrganizationName = OrganizationName;
            this.OfficeAddress = OrganizationAddress;

        }

    }
}
