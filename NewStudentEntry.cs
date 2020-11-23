using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentApp_WindowsForm_Version
{
    public partial class NewStudentEntry : Form
    {
        int flag = 0;
        int studentList;
        int entryCount = 0;
        static double lastRegisterNumber = 20100000;

        public NewStudentEntry(int flag)
        {
            InitializeComponent();
            this.flag = flag;

        }

        private void NewStudentEntry_Load(object sender, EventArgs e)
        {
            if (this.flag == 1)
            {
                this.studentList = 1;
                lbStudentName.Visible = true;
                lbStudentDOB.Visible = true;
                tbStudentName.Visible = true;
                dtpStudentDOB.Visible = true;
                btSubmitStudentData.Visible = true;

            }
            else if (this.flag == 2)
            {
                lbStudentEntry.Visible = true;
                tbStudentEntry.Visible = true;
                btDone.Visible = true;

            }

        }

        private void btDone_Click(object sender, EventArgs e)
        {
            Regex digits = new Regex(@"^\d$");
            if (digits.IsMatch(tbStudentEntry.Text))
            {
                this.studentList = int.Parse(tbStudentEntry.Text);
                lbStudentName.Visible = true;
                lbStudentDOB.Visible = true;
                tbStudentName.Visible = true;
                dtpStudentDOB.Visible = true;
                btSubmitStudentData.Visible = true;


                lbStudentEntry.Visible = false;
                tbStudentEntry.Visible = false;
                btDone.Visible = false;

            }



        }

        private void btSubmitStudentData_Click(object sender, EventArgs e)
        {

            while (this.entryCount <= this.studentList)
            {
                string studentName = tbStudentName.Text;
                DateTime dateOfBirth = dtpStudentDOB.Value;

                //MessageBox.Show(studentName + " " + dateOfBirth.ToString("d"));
                this.entryCount++;
                double studentRegisterNumber = lastRegisterNumber + 1;
                lastRegisterNumber = studentRegisterNumber;
                StudentDetails sendDetails = new StudentDetails(studentRegisterNumber, studentName, dateOfBirth);
                lbCounter.Visible = true;
                lbCounter.Text = "Remaining Students are" + (this.studentList - this.entryCount);

                tbStudentName.Text = "";

                break;

            }
            if (this.entryCount >= this.studentList)
            {
                btSubmitStudentData.Visible = false;
                lbCounter.Text = "Successfully entered all the data";
            }


        }


        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newStudentSingleEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var singleStudentEntry = new NewStudentEntry(1);
            this.Hide();
            singleStudentEntry.ShowDialog();
            this.Close();
        }

        private void newStudentMultipleEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var multipleStudentEntry = new NewStudentEntry(2);
            this.Hide();
            multipleStudentEntry.ShowDialog();
            this.Close();

        }

        private void viewExistingStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var viewStudent = new ViewStudent();
            this.Hide();
            viewStudent.ShowDialog();
            this.Close();

        }

        private void viewAllStudentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            

        }


    }



    public class StudentDetails

    {

        public static Dictionary<double, Tuple<string, string>> studentDataDump = new Dictionary<double, Tuple<string, string>>();

        public StudentDetails()

        {

            // gives error if this isnt present... No other purpose 

        }

        public StudentDetails(double registerNumber, string name, DateTime dateOfBirth)

        {

            studentDataDump.Add(registerNumber, Tuple.Create(name, dateOfBirth.ToString("d")));

            
            ViewStudent datapass = new ViewStudent(studentDataDump);
            //ViewAll datapassAll = new ViewAll(studentDataDump);
            
            StudentDataMessageBox(registerNumber);

        }

        public void StudentDataMessageBox(double registerNumber)
        {
            var studentDetails = studentDataDump[registerNumber];
            MessageBox.Show("Student Register Number : " + registerNumber + "\n Student Name: " + studentDetails.Item1+"\n DOB : "+studentDetails.Item2);
        }

        

        





    }


}
