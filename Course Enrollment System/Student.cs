using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Enrollment_System
{
    internal class Student: Participant
    {
        string HomeAddress = "";
        string SchoolName = "";

        public List <Enrollment> StudentEnrollmentList = new List<Enrollment>();


        public Student(string Name, int RegNo, string ContactNumber, string Email, string Level, string HomeAddress, string SchoolName) : base (Name, RegNo, ContactNumber, Email, Level)
        {
            this.HomeAddress = HomeAddress;
            this.SchoolName = SchoolName;   
        }
    }
}
