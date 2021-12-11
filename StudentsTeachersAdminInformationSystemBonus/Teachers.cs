using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTeachersAdminInformationSystemBonus
{
    internal class Teachers
    {
        private string TeacherName = "";
        private int TeacherID = 0;
        private string TeacherDepartment = "";
        private string TeacherDesignation = "";
        private double TeacherSalary = 0;

        public string GetTeacherName
        {
            get
            { return TeacherName; }
        }

        public string SetTeacherName
        {
            set
            { TeacherName = value; }
        }


        public int GetTeacherID
        {
            get { return TeacherID; }
        }

        public int SetTeacherID
        {
            set { TeacherID = value; }
        }

        public string GetTeacherDepartment
        {
            get { return TeacherDepartment; }
        }
        public string SetTeacherDepartment
        {
            set { TeacherDepartment = value; }
        }

        public string GetTeacherDesignation
        {
            get { return TeacherDesignation; }
        }
        public string SetTeacherDesignation
        {
            set { TeacherDesignation = value; }
        }
        public double GetTeacherSalary
        {
            get { return TeacherSalary; }
        }
        public double SetTeacherSalary
        {
            set { TeacherSalary = value; }
        }

        public string GetTeacherInfo()
        {
            string getInfo = GetTeacherID + "\t" + GetTeacherName + "\t" + GetTeacherDepartment + "\t" + GetTeacherDesignation + "\t" + GetTeacherSalary;
            return getInfo;
        }
    }
}
