using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp_WindowsForm_Version
{
    public partial class ViewStudent : Form
    {
        public static Dictionary<double, Tuple<string, string>> studentDataDump = new Dictionary<double, Tuple<string, string>>();
        static bool flag = false;
        public ViewStudent(Dictionary<double, Tuple<string, string>> studentDataPassed)
        {
            studentDataDump = studentDataPassed;
            flag = true;
            InitializeComponent();
        }
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                lbRegisterNumber.Visible = true;
                tbRegisterNumber.Visible = true;
                btSearch.Visible = true;
                btViewAll.Visible = true;
                
               
            }
            else
            {
                lbStatus.Visible = true;
                lbStatus.Text = "No Student Data entered";

            }

        }

        private void lbStatus_Click(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                double studentRegisterNumber = double.Parse(tbRegisterNumber.Text);

                var studentDetails = studentDataDump[studentRegisterNumber];
                dgvStudentTable.Visible = true;
                dgvStudentTable.ColumnCount = 3;
                dgvStudentTable.Columns[0].Name = "Register Number";
                dgvStudentTable.Columns[1].Name = "Student Name";
                dgvStudentTable.Columns[2].Name = "Date Of Birth";

                //dgvStudentTable.Rows.Add("Register Number", "Student Name", "Date Of Birth");
                dgvStudentTable.Rows.Add(studentRegisterNumber, studentDetails.Item1, studentDetails.Item2);
            }
            catch
            {
                MessageBox.Show("Enter Register Number : "+ tbRegisterNumber.Text+" is not Valid \n Please Try Again");
            }
        }

        private void btViewAll_Click(object sender, EventArgs e)
        {
            
            dgvStudentTable.Visible = true;
            
            dgvStudentTable.ColumnCount = 3;
            dgvStudentTable.Columns[0].Name = "Register Number";
            dgvStudentTable.Columns[1].Name = "Student Name";
            dgvStudentTable.Columns[2].Name = "Date Of Birth";
            dgvStudentTable.Rows.Clear();
            foreach(var kvp in studentDataDump)
            {
                var studentDetails = studentDataDump[kvp.Key];
                dgvStudentTable.Rows.Add(kvp.Key,studentDetails.Item1,studentDetails.Item2);
            }

        }

        private void newStudentSingleEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentEntry = new NewStudentEntry(1);
            this.Hide();
            studentEntry.ShowDialog();
            this.Close();

        }

        private void newStudentMultipleEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentEntry = new NewStudentEntry(2);
            this.Hide();
            studentEntry.ShowDialog();
            this.Close();
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
    }
}
