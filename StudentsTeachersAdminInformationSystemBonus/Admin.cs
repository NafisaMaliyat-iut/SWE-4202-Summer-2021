using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTeachersAdminInformationSystemBonus
{
    internal class Admin
    {
        private string AdminName = "";
        private int AdminID = 0;
        private string AdminDesignation = "";
        private double AdminSalary = 0.0;


        public string GetAdminName
        {
            get
            { return AdminName; }
        }

        public string SetAdminName
        {
            set
            { AdminName = value; }
        }


        public int GetAdminID
        {
            get { return AdminID; }
        }

        public int SetAdminID
        {
            set { AdminID = value; }
        }

        public string GetAdminDesignation
        {
            get { return AdminDesignation; }
        }
        public string SetAdminDesignation
        {
            set { AdminDesignation = value; }
        }

        public double GetAdminSalary
        {
            get { return AdminSalary; }
        }
        public double SetAdminSalary
        {
            set { AdminSalary = value; }
        }

        public string GetAdminInfo()
        {
            string getInfo = GetAdminID + "\t" + GetAdminName + "\t" + GetAdminDesignation + "\t" + GetAdminSalary;
            return getInfo;
        }
    }
}
