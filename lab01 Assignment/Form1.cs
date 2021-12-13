using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab01_Assignment
{
    public partial class GradesApp : Form
    {
        public GradesApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnterFinalMarks_Click(object sender, EventArgs e)
        {

        }

        public void DisplayResultWhenCLicked_Click(object sender, EventArgs e)
        {
            if (EnterStudentName.Text == "" ||
                EnterStudentID.Text == "" ||
                EnterSemester.Text == "" ||
                EnterAttendedClassesOutOf28.Text == "" ||
                EnterMidMarks.Text == "" ||
                EnterFinalMarks.Text == "" ||
                EnterQuiz1Marks.Text == "" ||
                EnterQuiz2Marks.Text == "" ||
                EnterQuiz3Marks.Text == "" ||
                EnterQuiz4Marks.Text == "")
            {
                MessageBox.Show("Check that you have entered all the fields.");
            }

            else
            {
                //display the attendance marks
                double AttendancePercentage = Convert.ToDouble(EnterAttendedClassesOutOf28.Text) / 28.0;
                double AttendanceMarks = AttendancePercentage * 30.0;
                DisplayAttendanceMarks.Text = Convert.ToString(Math.Round(AttendanceMarks, MidpointRounding.AwayFromZero)) + "/30";

                //Calculating quiz marks best of 3 
                double[] quizMarks = new double[4];
                quizMarks[0] = Convert.ToDouble(EnterQuiz1Marks.Text);
                quizMarks[1] = Convert.ToDouble(EnterQuiz2Marks.Text);
                quizMarks[2] = Convert.ToDouble(EnterQuiz3Marks.Text);
                quizMarks[3] = Convert.ToDouble(EnterQuiz4Marks.Text);
                Array.Sort(quizMarks);
                double totalQuizMarks = quizMarks[3] + quizMarks[2] + quizMarks[1];
                DisplayTotalQuizMarks.Text = Convert.ToString(Math.Round(totalQuizMarks, MidpointRounding.AwayFromZero)) + "/45";

                //display mid marks
                DisplayMidMarks.Text = EnterMidMarks.Text + "/75";

                //display final marks
                DisplayFinalMarks.Text = EnterFinalMarks.Text + "/150";

                //display total marks
                double totalMarks = AttendanceMarks + Convert.ToDouble(EnterFinalMarks.Text) + totalQuizMarks + Convert.ToDouble(EnterMidMarks.Text);
                DisplayTotalMarks.Text = Convert.ToString(Math.Round(totalMarks, MidpointRounding.AwayFromZero)) + "/300";

                //display the grade
                double TotalPercentage = (totalMarks / 300) * 100;
                string grade = "/0";
                if (TotalPercentage <= 100 && TotalPercentage >= 80)
                    grade = "A+";
                else if (TotalPercentage >= 75)
                    grade = "A";
                else if (TotalPercentage >= 70)
                    grade = "A-";
                else if (TotalPercentage >= 65)
                    grade = "B+";
                else if (TotalPercentage >= 60)
                    grade = "B";
                else if (TotalPercentage >= 55)
                    grade = "B-";
                else if (TotalPercentage >= 50)
                    grade = "C+";
                else if (TotalPercentage >= 45)
                    grade = "C";
                else if (TotalPercentage >= 40)
                    grade = "D";
                else if (TotalPercentage < 40)
                    grade = "F";

                DisplayGrades.Text = grade;

                //display Name and Percentage Message

                DisplayNameAndPercentage.Text = EnterStudentName.Text + " obtained " + Convert.ToString(Math.Round(TotalPercentage, MidpointRounding.AwayFromZero)) + "% marks.";
            }
        }

        private void DisplayMidMarks_Click(object sender, EventArgs e)
        {

        }

        
    }
}
