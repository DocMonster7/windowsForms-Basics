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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            int selectedOption = cbSelectOption.SelectedIndex;
            

            switch (selectedOption)
            {
                case 0:
                    var singleStudentEntry = new NewStudentEntry(1);
                    this.Hide();
                    singleStudentEntry.ShowDialog();
                    this.Close();
                    break;
                case 1:
                    var multipleStudentEntry = new NewStudentEntry(2);
                    this.Hide();
                    multipleStudentEntry.ShowDialog();
                    this.Close();
                    break;
                case 2:
                    var viewStudent = new ViewStudent();
                    this.Hide();
                    viewStudent.ShowDialog();
                    this.Close();
                    break;
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
