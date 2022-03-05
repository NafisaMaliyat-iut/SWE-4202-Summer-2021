using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Handling
{
    internal class Employee
    {
        public string EmployeeID;
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber;
        public string HireDate;
        public string JobID;
        public string ManagerID;
        public string Salary;
        public string DepartmentID;

        public string GetEmployeeInfo()
        {
            return EmployeeID + "   " + FirstName + " " + LastName 
                + "   " + Email + "   " + PhoneNumber + "   " + HireDate
                + "   " + JobID + "   " + Salary + "   " + ManagerID
                + "   " + DepartmentID;    
        }
    }
}
