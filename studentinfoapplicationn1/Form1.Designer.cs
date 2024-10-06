using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a new StudentInfo object using the constructor
            StudentInfo student = new StudentInfo(txtFirstName.Text, txtLastName.Text, txtStudentID.Text);

            // Add the student details to the list boxes
            lstFirstName.Items.Add(student.FirstName);
            lstLastName.Items.Add(student.LastName);
            lstStudentID.Items.Add(student.StudentID);
        }
        public class StudentInfo
        {
            private string firstName;
            private string lastName;
            private string studentID;

            // Encapsulation: Properties for accessing private variables
            public string FirstName
            {
                get { return firstName; }
                set { firstName = value; }
            }

            public string LastName
            {
                get { return lastName; }
                set { lastName = value; }
            }

            public string StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }

            // Constructor overloading
            public StudentInfo() { }

            public StudentInfo(string firstName, string lastName)
            {
                this.firstName = firstName;
                this.lastName = lastName;
            }

            public StudentInfo(string firstName, string lastName, string studentID)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.studentID = studentID;
            }
        }
    }
}
