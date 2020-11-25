using System;
using System.IO; 
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StudentApp_WindowsForm_Version
{
    public partial class NewStudentEntry : Form
    {
        
        static double lastRegisterNumber = 20100000;
        string studentFirstName, studentLastName, street, city, email,state,sex;
        double contactNumber,pin;
        DateTime dateOfBirth;
        public NewStudentEntry()
        {
            InitializeComponent();

        }

        private void NewStudentEntry_Load(object sender, EventArgs e)
        {
            

        }

        
        private void btSubmitStudentData_Click(object sender, EventArgs e)
        {
            this.studentFirstName = tbStudentFirstName.Text;
            this.studentLastName = tbStudentLastName.Text;
            this.street = tbStreet.Text;
            this.city = tbCity.Text;
            this.email = tbEmail.Text;
            this.sex = cbSex.Text;
            this.state = cbState.Text;
            this.contactNumber = Convert.ToDouble(tbContactNumber.Text);
            this.pin =Convert.ToDouble(tbPIN.Text);
            this.dateOfBirth = Convert.ToDateTime(dtpStudentDOB.Text);
            tbStudentFirstName.Text = "";
            tbStudentLastName.Text= "";
            tbStreet.Text= "";
            tbCity.Text= "";
            tbEmail.Text= "";
            cbSex.Text= "";
            cbState.Text= "";
            tbContactNumber.Text= "";
            tbPIN.Text= "";
            dtpStudentDOB.Text = "";

            StreamWriter sw = new StreamWriter(this.studentFirstName+".txt");
            sw.WriteLine("Student Name : "+this.studentFirstName+" "+this.studentLastName);
            sw.WriteLine("Street : "+this.street);
            sw.WriteLine("City : " + this.city);
            sw.WriteLine("Email : " + this.email);
            sw.WriteLine("Sex : " + this.sex);
            sw.WriteLine("State : " + this.state);
            sw.WriteLine("ContactNumber : " + this.contactNumber);
            sw.WriteLine("PIN : " + this.pin);
            sw.WriteLine("Date Of Birth : " + this.dateOfBirth);

            sw.Flush();
            sw.Close();
            MessageBox.Show("File successfully Stored in <Project Root location>/bin/Debug/" + this.studentFirstName + ".txt");


    
        }


       

        private void lbCounter_Click(object sender, EventArgs e)
        {

        }

        private void btResetStudentData_Click(object sender, EventArgs e)
        {
            tbStudentFirstName.Text = "";
            tbStudentLastName.Text = "";
            tbStreet.Text = "";
            tbCity.Text = "";
            tbEmail.Text = "";
            cbSex.Text = "";
            cbState.Text = "";
            tbContactNumber.Text = "";
            tbPIN.Text = "";
            dtpStudentDOB.Text = "";
            MessageBox.Show("Form Reset");
        }


    }



    


}
