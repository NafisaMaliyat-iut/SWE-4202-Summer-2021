using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTeachersAndAdminInformation
{
    internal class Students
    {
        private string StudentName = "\0";
        private int StudentId = 0;
        private string StudentDepartment = "\0";
        private int StudentSemester = 0;

        public string GetStudentName
        {
            get
            { return StudentName; }
        }

        public string SetStudentName
        {
            set
            { StudentName = value; }
        }


        public int GetStudentID
        {
            get { return StudentId; }
        }

        public int SetStudentID
        {
            set { StudentId = value; }
        }

        public int GetStudentSemester
        {
            get { return StudentSemester; }
        }
        public int SetStudentSemester
        {
            set { StudentSemester = value; }
        }

        public string GetStudentDepartment
        {
            get { return StudentDepartment; }
        }
        public string SetStudentDepartment
        {
            set { StudentDepartment = value; }
        }

        public string GetStudentInfo()
        {
            string getInfo = GetStudentID + "\t" + GetStudentName + "\t" + GetStudentDepartment + "\t" + GetStudentSemester;
            return getInfo;
        }


    }
}
