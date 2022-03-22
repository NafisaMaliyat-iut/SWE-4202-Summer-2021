using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUT_Result_Processing_System
{
    internal class Student
    {
        public string ID = "";
        public string Name = "";
        public string AttendanceMarks = "", MidTermMark = "", SemesterFinalMark = "", VivaMark= "";
        public double TotalQuizMark = 0, TotalOutOf300 = 0;
        public double Percentage = 0;
        public string Grade = "";

        public double[] QuizMarks = new double[4];

        public void Calculations()
        {
            Array.Sort(QuizMarks);

            TotalQuizMark = QuizMarks[3] + QuizMarks[2] + QuizMarks[1];

            int attendance, MidMarks, FinalsMarks, VivaMarks;
            if (this.AttendanceMarks == "")
                attendance = 0;
            else
                attendance = Convert.ToInt32(this.AttendanceMarks);

            if (this.MidTermMark == "")
                MidMarks = 0;
            else
                MidMarks = Convert.ToInt32(this.MidTermMark);

            if (this.SemesterFinalMark == "")
                FinalsMarks = 0;
            else
                FinalsMarks = Convert.ToInt32(this.SemesterFinalMark);

            if (this.VivaMark == "")
                VivaMarks = 0;
            else
                VivaMarks = Convert.ToInt32(this.VivaMark);

            this.TotalOutOf300 =  attendance + MidMarks + this.TotalQuizMark + FinalsMarks + VivaMarks;
                                
            this.Percentage = Math.Round(((TotalOutOf300 /300.00) * 100.00), 2);
            

            if (this.Percentage<= 100 && this.Percentage >= 80)
                this.Grade = "A+";
            else if (this.Percentage>=75)
                this.Grade = "A";
            else if (this.Percentage>=70)
                this.Grade = "A-";
            else if (this.Percentage>=65)
                this.Grade = "B+";
            else if (this.Percentage>=60)
                this.Grade = "B";
            else if (this.Percentage>=55)
                this.Grade = "B-";
            else if (this.Percentage>=50)
                this.Grade = "C+";
            else if (this.Percentage>=45)
                this.Grade = "C";
            else if (this.Percentage>=40)
                this.Grade = "D";
            else if (this.Percentage>=0)
                this.Grade = "F";
        }

    }
}
