using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Enrollment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Course_Enrollment_System IutCourseEnrollmentSystem = new Course_Enrollment_System();

        private void EnterParticipantInfoAddButton_Click(object sender, EventArgs e)
        {
            //if all type buttons are unchecked
            if (EnterParticipantInfoTypeProfessional.Checked == false
               & EnterParticipantInfoTypeStudent.Checked == false)
            {
                MessageBox.Show("Select a Type!");
                return;
            }

            //if any of the written fields are empty
            if (EnterParticipantInfoRegNo.Text == String.Empty
                || EnterParticipantInfoName.Text == String.Empty
                || EnterParticipantInfoEmail.Text == String.Empty
                || EnterParticipantInfoContactNo.Text == String.Empty)
            {
                MessageBox.Show("Fill up all the fields!");
                return;
            }

            // IF THE PARTICIPANT IS A STUDENT

            if(EnterParticipantInfoTypeStudent.Checked == true)
            {
                // if the registration number entered unique
                foreach (Student student in IutCourseEnrollmentSystem.StudentList)
                {
                    if(Convert.ToInt32(EnterParticipantInfoRegNo.Text) == student.GetRegistrationNumber())
                    {
                        MessageBox.Show("Participant already exists!");
                        return;
                    }

                }

                string ParticipantLevel = "Beginner";

                if (EnterParticipantInfoLevelAdvanced.Checked == false & EnterParticipantInfoLevelBeginner.Checked == false & EnterParticipantInfoLevelIntermediate.Checked == false)
                    ParticipantLevel = "Beginner";
                else if (EnterParticipantInfoLevelAdvanced.Checked == true)
                    ParticipantLevel = "Advanced";
                else if (EnterParticipantInfoLevelBeginner.Checked == true)
                    ParticipantLevel = "Beginner";
                else if (EnterParticipantInfoLevelIntermediate.Checked == true)
                    ParticipantLevel = "Intermediate";
                
                //calling constructor
                Student DummyStudent = new Student (EnterParticipantInfoName.Text, 
                                                    Convert.ToInt32(EnterParticipantInfoRegNo.Text), 
                                                    EnterParticipantInfoContactNo.Text, 
                                                    EnterParticipantInfoEmail.Text, 
                                                    ParticipantLevel, 
                                                    EnterParticipantInfoAddress.Text, 
                                                    EnterParticipantInfoOrgName.Text) ;
                
                IutCourseEnrollmentSystem.StudentList.Add(DummyStudent);
                MessageBox.Show("Student added to the list successfully!");
                EnrollCourseSelectParticipant.Items.Add(DummyStudent.GetRegistrationNumber());
                ViewEnrolledCoursesDropDown.Items.Add(DummyStudent.GetRegistrationNumber());

            }

            // IF PARTICIPIANT IS A PROFESSIONAL    
            else if(EnterParticipantInfoTypeProfessional.Checked == true)
            {
                // if the registration number entered unique
                foreach (Professional professional in IutCourseEnrollmentSystem.ProfessionalList)
                {
                    if (Convert.ToInt32(EnterParticipantInfoRegNo.Text) == professional.GetRegistrationNumber())
                    {
                        MessageBox.Show("Participant already exists!");
                        return;
                    }

                }

                string ParticipantLevel = "Beginner";

                if (EnterParticipantInfoLevelAdvanced.Checked == false & EnterParticipantInfoLevelBeginner.Checked == false & EnterParticipantInfoLevelIntermediate.Checked == false)
                    ParticipantLevel = "Beginner";
                else if (EnterParticipantInfoLevelAdvanced.Checked == true)
                    ParticipantLevel = "Advanced";
                else if (EnterParticipantInfoLevelBeginner.Checked == true)
                    ParticipantLevel = "Beginner";
                else if (EnterParticipantInfoLevelIntermediate.Checked == true)
                    ParticipantLevel = "Intermediate";

                //calling constructor
                Professional DummyProfessional = new Professional (EnterParticipantInfoName.Text, 
                                                    Convert.ToInt32(EnterParticipantInfoRegNo.Text), 
                                                    EnterParticipantInfoContactNo.Text, 
                                                    EnterParticipantInfoEmail.Text, 
                                                    ParticipantLevel, 
                                                    EnterParticipantInfoAddress.Text, 
                                                    EnterParticipantInfoOrgName.Text);

                IutCourseEnrollmentSystem.ProfessionalList.Add (DummyProfessional);
                MessageBox.Show("Professional added to the list successfully!");
                EnrollCourseSelectParticipant.Items.Add(DummyProfessional.GetRegistrationNumber());
                ViewEnrolledCoursesDropDown.Items.Add(DummyProfessional.GetRegistrationNumber());
            }

        }




        private void EnterCourseInfoAddButtonClick(object sender, EventArgs e)
        {
            if (EnterCourseInfoCourseFee.Text == String.Empty
                || EnterCourseInfoTitle.Text == String.Empty)
            {
                MessageBox.Show("Fill up all the fields!");
                return;
            }
            
            //check if course title is unique
            foreach (Course course in IutCourseEnrollmentSystem.CourseList)
            {
                if (EnterCourseInfoTitle.Text == course.GetCourseTitle())
                {
                    MessageBox.Show("Course already exists!");
                    return;
                }

            }

            string CourseLevel = "Beginner";
            if (EnterCourseInfoLevelIntermediate.Checked == true)
                CourseLevel = "Intermediate";
            else if (EnterCourseInfoLevelBeginner.Checked == true)
                CourseLevel = "Beginner";
            else if (EnterCourseInfoLevelAdvanced.Checked == true)
                CourseLevel = "Advanced";

            //calling constructor
            Course DummyCourse = new Course(EnterCourseInfoTitle.Text,
                                            CourseLevel,
                                            Convert.ToDouble(EnterCourseInfoCourseFee.Text));

            IutCourseEnrollmentSystem.CourseList.Add (DummyCourse);
            EnrollCourseSelectCourse.Items.Add(DummyCourse.GetCourseTitle());
            MessageBox.Show("Course added successfully!");

        }







        private void PayAndEnrollButtonOnClick(object sender, EventArgs e)
        {
            //searching for the course level 
            string CourseLevel = "";
            foreach(Course course in IutCourseEnrollmentSystem.CourseList)
            {
                if (course.GetCourseTitle() == EnrollCourseSelectCourse.Text)
                {
                    CourseLevel = course.GetCourseLevel();

                }
            }



            //if the enrollment professional or student
            string ParticipantType ="";
            string ParticipantLevel = "";
            
            foreach(Student student in IutCourseEnrollmentSystem.StudentList)
            {
                if(student.GetRegistrationNumber() == Convert.ToInt32(EnrollCourseSelectParticipant.Text))
                {
                    ParticipantType = "Student";
                    ParticipantLevel = student.GetParticipantLevel();

                    //if participant and course level matches
                    bool LevelMatches = false;

                    if (ParticipantLevel == CourseLevel)
                        LevelMatches = true;

                    Enrollment DummyEnrollment = new Enrollment(EnrollCourseSelectCourse.Text, ParticipantLevel, Convert.ToInt32(EnrollCourseSelectParticipant.Text), Convert.ToDouble(EnrollCourseCourseFeeDisplay.Text), Convert.ToString(EnrollCourseEnrollmentDate.Text)); 
                    
                    if(LevelMatches)
                    {
                        
                        student.StudentEnrollmentList.Add(DummyEnrollment);
                        MessageBox.Show("Enrollment completed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Level of the course and participant does not match!");
                        return;
                    }
                        
                    break;
                }
            }

            if(ParticipantType == "")
            {
                foreach(Professional professional in IutCourseEnrollmentSystem.ProfessionalList)
                {
                    if(professional.GetRegistrationNumber() == Convert.ToInt32(EnrollCourseSelectParticipant.Text))
                    {
                        ParticipantType = "Professional";
                        ParticipantLevel = professional.GetParticipantLevel();

                        //if participant and course level matches
                        bool LevelMatches = false;

                        if (ParticipantLevel == CourseLevel)
                            LevelMatches = true;

                        ProfessionalEnrollment DummyProfessionalEnrollment = new ProfessionalEnrollment(EnrollCourseSelectCourse.Text, ParticipantLevel, Convert.ToInt32(EnrollCourseSelectParticipant.Text), Convert.ToDouble(EnrollCourseCourseFeeDisplay.Text), Convert.ToString(EnrollCourseEnrollmentDate.Text));

                        if (LevelMatches)
                        {
                            professional.ProfessionalEnrollmentList.Add(DummyProfessionalEnrollment);
                            MessageBox.Show("Enrollment completed successfully!");
                        }

                        break;
                    }
                }
            }

            
        }





        private void ViewEnrolledCoursesButton_Click(object sender, EventArgs e)
        {
            ViewEnrolledCoursesListBox.Items.Clear();
            ViewEnrolledCoursesListBox.Items.Add("Course\tLevel\t     Fees\tEnrollment Date");

            bool ParticipantFound = false;

            foreach(Student student in IutCourseEnrollmentSystem.StudentList)
            {
                if(student.GetRegistrationNumber() == Convert.ToInt32(ViewEnrolledCoursesDropDown.Text))
                {
                    ParticipantFound = true;
                    foreach (Enrollment ThisStudentEnrollments in student.StudentEnrollmentList)
                    {
                        ViewEnrolledCoursesListBox.Items.Add(ThisStudentEnrollments.GetEnrollmentInfo());
                    }
                }
            }

            if(!ParticipantFound)
            {
                foreach(Professional professional in IutCourseEnrollmentSystem.ProfessionalList)
                {
                    if(professional.GetRegistrationNumber() == Convert.ToInt32(ViewEnrolledCoursesDropDown.Text))
                    {
                        ParticipantFound=true;
                        foreach (ProfessionalEnrollment ThisProfessionalEnrollment in professional.ProfessionalEnrollmentList)
                        {
                            ViewEnrolledCoursesListBox.Items.Add(ThisProfessionalEnrollment.GetEnrollmentInfo());
                        }
                    }
                }
            }

        }

        private void EnrollCourseSelectCourseEvent(object sender, EventArgs e)
        {
            foreach(Course course in IutCourseEnrollmentSystem.CourseList)
            {
                if(course.GetCourseTitle() == EnrollCourseSelectCourse.Text)
                {
                    EnrollCourseCourseFeeDisplay.Text = Convert.ToString(course.GetFees());
                    break;
                }
            }
        }
    }
}
