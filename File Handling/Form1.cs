using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Handling
{
    public partial class Form1 : Form
    {

        Employee_Database MyEmployeeDatabase = new Employee_Database();

        public Form1()
        {
            InitializeComponent();



            using (var reader = new System.IO.StreamReader(@"D:\OOC I\File Handling\employees.csv"))
            {
                while (!reader.EndOfStream )
                {
                    Employee employee = new Employee();
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    employee.EmployeeID = values[0];
                    values = line.Split(',');
                    employee.FirstName = values[1];
                    values = line.Split(',');
                    employee.LastName = values[2];
                    values = line.Split(',');
                    employee.Email = values[3];
                    values = line.Split(',');
                    employee.PhoneNumber = values[4];
                    values = line.Split(',');
                    employee.HireDate = values[5];
                    values = line.Split(',');
                    employee.JobID = values[6];
                    values = line.Split(',');
                    employee.Salary = values[7];
                    values = line.Split(',');
                    employee.ManagerID = values[8];
                    values = line.Split(',');
                    employee.DepartmentID = values[9];

                    MyEmployeeDatabase.employees.Add(employee);
                    DisplayAllEmployeeListBox.Items.Add(employee.EmployeeID + "  " 
                                                        + employee.FirstName + "   " 
                                                        + employee.LastName);
                    

                }

            }

            
        }

        private void SearchEmployeeButtonClick(object sender, EventArgs e)
        {
            bool EmployeeFound = false;

            foreach (Employee employee in MyEmployeeDatabase.employees)
            {
                if (SearchEmployeeTxtbox.Text == employee.EmployeeID)
                {
                    EmployeeFound = true;
                    Console.WriteLine("Search done once");

                    string path = @"D:\OOC I\File Handling\log.txt";
                    using (System.IO.StreamWriter sw = File.AppendText(path))
                    {
                        sw.Write(Convert.ToString(DateTime.Now) + "\t" 
                            + employee.EmployeeID + "\tFound\t"
                            + employee.FirstName + "\t"
                            + employee.LastName + "\t"
                            + employee.Email + "\t"
                            + employee.PhoneNumber + "\t"
                            + employee.HireDate + "\t"
                            + employee.JobID + "\t"
                            + employee.Salary + "\t"
                            + employee.ManagerID + "\t"
                            + employee.DepartmentID + "\n");
                        
                    }
                    SearchEmployeeListBox.Items.Add(employee.GetEmployeeInfo());
                    break;

                }
            }

            if (!EmployeeFound)
            {
                MessageBox.Show("Employee does not exist!");
                string path = @"D:\SWE-4202-LAB-200042133\Employees\log.txt";
                using (System.IO.StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(Convert.ToString(DateTime.Now) + "\t" 
                        + SearchEmployeeTxtbox.Text + "\tNot Found\n");
                }
                return;
            }
        }
    }
}
