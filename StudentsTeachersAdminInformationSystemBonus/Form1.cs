using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsTeachersAdminInformationSystemBonus
{
    public partial class StudentTeacherAdminInfoBonus : Form
    {
        public StudentTeacherAdminInfoBonus()
        {
            InitializeComponent();
        }

        readonly List<Students> StudentList = new List<Students>();
        readonly List<Teachers> TeacherList = new List<Teachers>();
        readonly List<Admin> AdminList = new List<Admin>();

        private void SaveStudentInfoOnClick(object sender, EventArgs e)
        {
            int StudentID = Convert.ToInt32(EnterStudentID.Text);
            string StudentName = EnterStudentName.Text;
            string StudentDepartment = EnterStudentDepartment.Text;
            int StudentSemester = Convert.ToInt32(EnterStudentSemester.Text);

            Students dummyStudent = new Students()
            {
                SetStudentName = StudentName,
                SetStudentID = StudentID,
                SetStudentDepartment = StudentDepartment,
                SetStudentSemester = StudentSemester,
            };

            StudentList.Add(dummyStudent);

            MessageBox.Show("Student has been added successfully!");

            StudentListBox.Items.Clear();
            foreach (Students student in StudentList)
            {
                StudentListBox.Items.Add(student.GetStudentInfo());
            }
        }

        private void ClearStudentInfoOnClick(object sender, EventArgs e)
        {
            EnterStudentName.Text = String.Empty;
            EnterStudentID.Text = String.Empty;
            EnterStudentDepartment.Text = String.Empty;
            EnterStudentSemester.Text = String.Empty;

            MessageBox.Show("Cleared Successfully!");
        }

        private void SaveTeacherInfoOnClick(object sender, EventArgs e)
        {
            int TeacherID = Convert.ToInt32(EnterTeacherID.Text);
            string TeacherName = EnterTeacherName.Text;
            string TeacherDepartment = EnterTeacherDepartment.Text;
            string TeacherDesignation = EnterTeacherDesignation.Text;
            double TeacherSalary = Convert.ToDouble(EnterTeacherSalary.Text);

            Teachers dummyTeacher = new Teachers()
            {
                SetTeacherName = TeacherName,
                SetTeacherDesignation = TeacherDesignation,
                SetTeacherID = TeacherID,
                SetTeacherDepartment = TeacherDepartment,
                SetTeacherSalary = TeacherSalary,
            };

            TeacherList.Add(dummyTeacher);

            MessageBox.Show("Teacher has been added successfully!");

            TeacherListBox.Items.Clear();
            foreach (Teachers teacher in TeacherList)
            {
                TeacherListBox.Items.Add(teacher.GetTeacherInfo());
            }
        }

        private void ClearTeacherInfoOnClick(object sender, EventArgs e)
        {
            EnterTeacherDepartment.Text = String.Empty;
            EnterTeacherDesignation.Text = String.Empty;
            EnterTeacherID.Text = String.Empty;
            EnterTeacherName.Text = String.Empty;
            EnterTeacherSalary.Text = String.Empty;

            MessageBox.Show("Cleared successfully!");
        }

        private void SaveAdminInfoOnClick(object sender, EventArgs e)
        {
            string AdminName = EnterAdminName.Text;
            int AdminID = Convert.ToInt32(EnterAdminID.Text);
            string AdminDesignation = EnterAdminDesignation.Text;
            double AdminSalary = Convert.ToDouble(EnterAdminSalary.Text);

            Admin dummyAdmin = new Admin()
            {
                SetAdminName = AdminName,
                SetAdminID = AdminID,
                SetAdminDesignation = AdminDesignation,
                SetAdminSalary = AdminSalary,
            };

            AdminList.Add(dummyAdmin);

            MessageBox.Show("Admin added successfully!");

            AdminListBox.Items.Clear();
            foreach (Admin admin in AdminList)
            {
                AdminListBox.Items.Add(admin.GetAdminInfo());
            }
        }

        private void ClearAdminInfoOnClick(object sender, EventArgs e)
        {
            EnterAdminDesignation.Text = String.Empty;
            EnterAdminID.Text = String.Empty;
            EnterAdminName.Text = String.Empty;
            EnterAdminSalary.Text = String.Empty;

            MessageBox.Show("Cleared Successfully!");
        }
    }
}
