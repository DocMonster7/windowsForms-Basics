using System;
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

            

        }


       

        private void lbCounter_Click(object sender, EventArgs e)
        {

        }


    }



    


}
