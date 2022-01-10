using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Enrollment_System
{
    internal class Participant
    {
        string Name = "";
        int RegistrationNumber = 0;
        string ContactNumber = "";
        string Email = "";
        string Level = "Beginner";

        public Participant(string name, int regNo, string contactNumber, string email, string level)
        { 
            this.Name = name;
            this.RegistrationNumber = regNo;
            this.ContactNumber = contactNumber;
            this.Email = email;
            this.Level = level;
        }

        public string GetParticipantLevel()
        {
            return this.Level;
        }

        public int GetRegistrationNumber()
        {
            return this.RegistrationNumber;
        }

        public void SetRegistrationNumber(int value)
        {
            this.RegistrationNumber = value;
        }

    }
}
