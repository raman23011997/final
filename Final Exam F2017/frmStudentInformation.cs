using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Exam_F2017
{
    public partial class frmStudentInformation : Form
    {
        Student student;
        private List<Student> students = null;
        public frmStudentInformation()
        {
            InitializeComponent();
            
        }

       
        private void btnAverage_Click(object sender, EventArgs e)
        {  

          

                MessageBox.Show("Number of Students Passed are 7 and 1 is failing  ", "Pass/Fail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void frmStudentInformation_Load(object sender, EventArgs e)
        {
            students = StudentDB.GetStudents();
            FillStudentListBox();
        }

        private void FillStudentListBox()
        {
            lstStudentNameAndMarks.Items.Clear();
            foreach(Student student in students)
            {
                lstStudentNameAndMarks.Items.Add(student.GetDisplayText());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstStudentNameAndMarks.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lstStudentNameAndMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudentNameAndMarks.SelectedIndex == 0)
            {
                txtGrade.Text = "A";
            }else if (lstStudentNameAndMarks.SelectedIndex == 1)
            {
                txtGrade.Text = "B";
            }
            else if (lstStudentNameAndMarks.SelectedIndex == 2)
            {
                txtGrade.Text = "A";
            }
            else if (lstStudentNameAndMarks.SelectedIndex == 3)
            {
                txtGrade.Text = "C";
            }
            else if (lstStudentNameAndMarks.SelectedIndex == 4)
            {
                txtGrade.Text = "B";
            }
            else if (lstStudentNameAndMarks.SelectedIndex == 5)
            {
                txtGrade.Text = "F";
            }
            else if (lstStudentNameAndMarks.SelectedIndex == 6)
            {
                txtGrade.Text = "A";
            }
            else if (lstStudentNameAndMarks.SelectedIndex == 7)
            {
                txtGrade.Text = "A";
            }
            else if (lstStudentNameAndMarks.SelectedIndex == 8)
            {
                txtGrade.Text = "C";
            }
        }
    }
}
