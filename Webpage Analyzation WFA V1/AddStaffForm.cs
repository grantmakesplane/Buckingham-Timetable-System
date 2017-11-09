using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webpage_Analyzation_WFA_V1
{
    public partial class AddStaffForm : Form
    {
        private int staff;
        private string id;
        private int degree;
        private int grade;
        private int term;
        private int major;
        private string firstName;
        private string middleName;
        private string lastName;
        private string department_1;
        private string department_2;
        //private List<string> staffDetailsList;


         

        //private int asdf;

        public AddStaffForm()
        {
            id = "0";
            degree = 1;
            grade = 1;
            term = 1;

            InitializeComponent();

            
            
        }

        private void departmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            department_1 = departmentComboBox1.Text;
        }

        private void departmentComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            department_2 = departmentComboBox2.Text;
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            id = idTextBox.Text;
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
        }

        private void middleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            middleName = middleNameTextBox.Text;
        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastName = lastNameTextBox.Text;
        }

        //private void addStaffDetailsGroupBox_Enter(object sender, EventArgs e)
        //{
        //    if (studentRadioButton.Checked)
        //    {
        //        staff = 1;
        //        studentDetailsGroupBox.Visible = true;
        //    }
        //    else if (LecturerRadioButton.Checked)
        //    {
        //        staff = 2;
        //        studentDetailsGroupBox.Visible = false;
        //    }
                
        //}

        private void AddStaffFormAddButton_Click(object sender, EventArgs e)
        {
            //MessageWarning();

            //foreach (string element in staffDetailsList)
            //{
            //    if (element == "" || element == "middleName)
            //        MessageBox.Show("Please complete the form!");
            //}
            if (id == null)
                MessageWarning("ID");
            else if (firstName == null)
                MessageWarning("first name");
            else if (middleName == null)
                MessageWarning("middle name");
            else if (lastName == null)
                MessageWarning("last name");
            //else if (department_1 == "None" && department_2 == "None")
            //    MessageWarning("department");
            else if (studentRadioButton.Checked)
            {
                Student newStudent = new Student();

                newStudent.Id = int.Parse(id);
                newStudent.FirstName = firstName;
                newStudent.MiddleName = middleName;
                newStudent.LastName = lastName;
                //newStudent.Department_1 = department_1;
                //newStudent.Department_2 = department_2;
                newStudent.Degree = degree;
                newStudent.Grade = grade;
                newStudent.Term = term;
                //newStudent.Major = major;
                if(!newStudent.uniqueIDChecking(int.Parse(id)))
                {
                    MessageBox.Show("The student ID: " + id + " is exist.");
                }else
                {
                    SystemList.StudentList.Add(newStudent);
                    SavingAndReading data = new SavingAndReading();
                    data.WriteStudentFile();
                }
                

            }
            else if (LecturerRadioButton.Checked)
            {
                Lecturer newLecturer = new Lecturer();
                newLecturer.Id = int.Parse(id);
                newLecturer.FirstName = firstName;
                newLecturer.MiddleName = middleName;
                newLecturer.LastName = lastName;
                
                if(!newLecturer.uniqueIDChecking(int.Parse(id)))
                {
                    MessageBox.Show("The lecturer ID: " + id + " is exist.");
                }else
                {
                    SystemList.LecturerList.Add(newLecturer);
                    SavingAndReading data = new SavingAndReading();
                    data.WriteLecturerFile();
                }
            }
        }

        private void MessageWarning(string warningMessage)
        {
            MessageBox.Show("Please complete " + warningMessage + ".");
        }

        private void idTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            idTextBox.Text = "";
        }

        private void firstNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            firstNameTextBox.Text = "";
        }

        private void middleNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            middleNameTextBox.Text = "";
        }

        private void lastNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            lastNameTextBox.Text = "";
        }

        private void studentRadioButton_MouseClick(object sender, MouseEventArgs e)
        {
            staff = 1;
            studentDetailsGroupBox.Visible = true;
        }

        private void LecturerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            staff = 2;
            studentDetailsGroupBox.Visible = false;
        }

        private void undergraduateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            degree = 1;
        }

        private void postgraduateButton_CheckedChanged(object sender, EventArgs e)
        {
            degree = 2;
        }

        private void year_1_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            grade = 1;
        }

        private void year_2_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            grade = 2;
        }

        private void year_3_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            grade = 3;
        }

        private void year_4_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            grade = 4;
        }

        private void winterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            term = 1;
        }

        private void springRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            term = 2;
        }

        private void summerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            term = 3;
        }

        private void autumnRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            term = 4;
        }

        private void majorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // in the future here we creater an object which include all majors.
            // in this event, it will also check which major a user select, and give an id to 'major'.
            //major = majorComboBox.Text;
            //if (majorComboBox.Text == "Pure Computing")
            //    major = 101;
        }
    }
}
