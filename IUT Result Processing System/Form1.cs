using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUT_Result_Processing_System
{
    public partial class Form1 : Form
    {

        StudentMarksDatabase IUTStudentMarkDatabase = new StudentMarksDatabase();
        public Form1()
        {
            InitializeComponent();

            

            using (var reader = new System.IO.StreamReader(@"D:\OOC I\IUT Result Processing System\SWE4201MarkSheet.csv"))
            {
                while (!reader.EndOfStream)
                {
                    Student dummyStudent = new Student();
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    dummyStudent.ID = values[0];
                    values = line.Split(',');

                    dummyStudent.Name = values[1];
                    values = line.Split(',');

                    dummyStudent.AttendanceMarks = values[2];
                    values = line.Split(',');

                    string temp;
                    temp = values[3];
                    if(temp == "")
                        dummyStudent.QuizMarks[0] = 0;
                    else
                        dummyStudent.QuizMarks[0] = Convert.ToInt32(temp);
                    values = line.Split(',');

                    temp = values[4];
                    if (temp == "")
                        dummyStudent.QuizMarks[1] = 0;
                    else
                        dummyStudent.QuizMarks[1] = Convert.ToInt32(temp);
                    values = line.Split(',');

                    temp = values[5];
                    if (temp == "")
                        dummyStudent.QuizMarks[2] = 0;
                    else
                        dummyStudent.QuizMarks[2] = Convert.ToInt32(temp);
                    values = line.Split(',');

                    temp = values[6];
                    if (temp == "")
                        dummyStudent.QuizMarks[3] = 0;
                    else
                        dummyStudent.QuizMarks[3] = Convert.ToInt32(temp); 
                    values = line.Split(',');

                    dummyStudent.MidTermMark = values[7];
                    values = line.Split(',');

                    dummyStudent.SemesterFinalMark = values[8];
                    values = line.Split(',');

                    dummyStudent.VivaMark = values[9];

                    dummyStudent.Calculations();


                    IUTStudentMarkDatabase.students.Add(dummyStudent);

                    int numberOfSpaces = 35 - dummyStudent.Name.Length ;
                    
                    string spaces = string.Empty;
                    for (int i = 0; i < numberOfSpaces; i++)
                    {
                        spaces = spaces + " ";
                    }
                    DisplayStudentMarks.Items.Add(Convert.ToString(dummyStudent.ID) + "    "
                                                  + dummyStudent.Name + spaces
                                                  + dummyStudent.Percentage + "%\t"
                                                  + dummyStudent.Grade);

                    SearchStudentComboBox.Items.Add(dummyStudent.ID);   
                }

            }
        }

        private void SearchByIDButton(object sender, EventArgs e)
        {
            var SearchResult = from student in IUTStudentMarkDatabase.students
                               where SearchStudentComboBox.Text == student.ID
                               select student;


            foreach(var result in SearchResult)
            {
                ShowAttendance.Text = result.AttendanceMarks;
                ShowQuiz1Mark.Text = Convert.ToString(result.QuizMarks[0]);
                ShowQuiz2Mark.Text = Convert.ToString(result.QuizMarks[1]);
                ShowQuiz3Mark.Text = Convert.ToString(result.QuizMarks[2]);
                ShowQuiz4Mark.Text = Convert.ToString(result.QuizMarks[3]);
                ShowQuizTotal.Text = Convert.ToString(result.TotalQuizMark);
                ShowMid.Text = result.MidTermMark;
                ShowFinal.Text = result.SemesterFinalMark;
                ShowVivaMark.Text = result.VivaMark;
                ShowTotalOutOf300.Text = Convert.ToString(result.TotalOutOf300);
                ShowPercentage.Text = result.Percentage + "%";
                ShowGrade.Text = result.Grade;

               
            }
        }
    }
}
