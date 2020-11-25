namespace StudentApp_WindowsForm_Version
{
    partial class NewStudentEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbStudentFirstName = new System.Windows.Forms.Label();
            this.tbStudentFirstName = new System.Windows.Forms.TextBox();
            this.lbStudentDOB = new System.Windows.Forms.Label();
            this.dtpStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btSubmitStudentData = new System.Windows.Forms.Button();
            this.lbStudentLastName = new System.Windows.Forms.Label();
            this.tbStudentLastName = new System.Windows.Forms.TextBox();
            this.plStudentBasicDetails = new System.Windows.Forms.Panel();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbCity = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbPIN = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btResetStudentData = new System.Windows.Forms.Button();
            this.plStudentBasicDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbStudentFirstName
            // 
            this.lbStudentFirstName.AutoSize = true;
            this.lbStudentFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentFirstName.Location = new System.Drawing.Point(17, 14);
            this.lbStudentFirstName.Name = "lbStudentFirstName";
            this.lbStudentFirstName.Size = new System.Drawing.Size(151, 20);
            this.lbStudentFirstName.TabIndex = 3;
            this.lbStudentFirstName.Text = " Student First Name";
            // 
            // tbStudentFirstName
            // 
            this.tbStudentFirstName.Location = new System.Drawing.Point(219, 14);
            this.tbStudentFirstName.Name = "tbStudentFirstName";
            this.tbStudentFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbStudentFirstName.TabIndex = 4;
            // 
            // lbStudentDOB
            // 
            this.lbStudentDOB.AutoSize = true;
            this.lbStudentDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentDOB.Location = new System.Drawing.Point(21, 77);
            this.lbStudentDOB.Name = "lbStudentDOB";
            this.lbStudentDOB.Size = new System.Drawing.Size(102, 20);
            this.lbStudentDOB.TabIndex = 5;
            this.lbStudentDOB.Text = "Date Of Birth";
            // 
            // dtpStudentDOB
            // 
            this.dtpStudentDOB.Location = new System.Drawing.Point(219, 77);
            this.dtpStudentDOB.Name = "dtpStudentDOB";
            this.dtpStudentDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpStudentDOB.TabIndex = 6;
            this.dtpStudentDOB.Value = new System.DateTime(1997, 9, 7, 0, 0, 0, 0);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(276, 24);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(228, 22);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "New Student Entry Form";
            // 
            // btSubmitStudentData
            // 
            this.btSubmitStudentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmitStudentData.Location = new System.Drawing.Point(243, 384);
            this.btSubmitStudentData.Name = "btSubmitStudentData";
            this.btSubmitStudentData.Size = new System.Drawing.Size(119, 38);
            this.btSubmitStudentData.TabIndex = 8;
            this.btSubmitStudentData.Text = "Submit";
            this.btSubmitStudentData.UseVisualStyleBackColor = true;
            this.btSubmitStudentData.Click += new System.EventHandler(this.btSubmitStudentData_Click);
            // 
            // lbStudentLastName
            // 
            this.lbStudentLastName.AutoSize = true;
            this.lbStudentLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentLastName.Location = new System.Drawing.Point(21, 44);
            this.lbStudentLastName.Name = "lbStudentLastName";
            this.lbStudentLastName.Size = new System.Drawing.Size(147, 20);
            this.lbStudentLastName.TabIndex = 11;
            this.lbStudentLastName.Text = "Student Last Name";
            // 
            // tbStudentLastName
            // 
            this.tbStudentLastName.Location = new System.Drawing.Point(219, 46);
            this.tbStudentLastName.Name = "tbStudentLastName";
            this.tbStudentLastName.Size = new System.Drawing.Size(100, 20);
            this.tbStudentLastName.TabIndex = 12;
            // 
            // plStudentBasicDetails
            // 
            this.plStudentBasicDetails.Controls.Add(this.cbSex);
            this.plStudentBasicDetails.Controls.Add(this.lbGender);
            this.plStudentBasicDetails.Controls.Add(this.lbStudentFirstName);
            this.plStudentBasicDetails.Controls.Add(this.tbStudentLastName);
            this.plStudentBasicDetails.Controls.Add(this.tbStudentFirstName);
            this.plStudentBasicDetails.Controls.Add(this.lbStudentLastName);
            this.plStudentBasicDetails.Controls.Add(this.dtpStudentDOB);
            this.plStudentBasicDetails.Controls.Add(this.lbStudentDOB);
            this.plStudentBasicDetails.Location = new System.Drawing.Point(132, 49);
            this.plStudentBasicDetails.Name = "plStudentBasicDetails";
            this.plStudentBasicDetails.Size = new System.Drawing.Size(470, 164);
            this.plStudentBasicDetails.TabIndex = 13;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbSex.Location = new System.Drawing.Point(219, 111);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 21);
            this.cbSex.TabIndex = 14;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(21, 111);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(36, 20);
            this.lbGender.TabIndex = 13;
            this.lbGender.Text = "Sex";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbState);
            this.panel1.Controls.Add(this.tbContactNumber);
            this.panel1.Controls.Add(this.tbPIN);
            this.panel1.Controls.Add(this.tbCity);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbStreet);
            this.panel1.Controls.Add(this.lbStreet);
            this.panel1.Controls.Add(this.lbCity);
            this.panel1.Controls.Add(this.lbState);
            this.panel1.Controls.Add(this.lbPIN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbEmail);
            this.panel1.Location = new System.Drawing.Point(132, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 146);
            this.panel1.TabIndex = 14;
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "Andhra Pradesh (AP)",
            "Arunachal Pradesh (AR)",
            "Assam (AS)",
            "Bihar (BR)",
            "Chhattisgarh (CG)",
            "Goa (GA)",
            "Gujarat (GJ)",
            "Haryana (HR)",
            "Himachal Pradesh (HP)",
            "Jammu and Kashmir (JK)",
            "Jharkhand (JH)",
            "Karnataka (KA)",
            "Kerala (KL)",
            "Madhya Pradesh (MP)",
            "Maharashtra (MH)",
            "Manipur (MN)",
            "Meghalaya (ML)",
            "Mizoram (MZ)",
            "Nagaland (NL)",
            "Odisha(OR)",
            "Punjab (PB)",
            "Rajasthan (RJ)",
            "Sikkim (SK)",
            "Tamil Nadu (TN)",
            "Telangana (TS)",
            "Tripura (TR)",
            "Uttar Pradesh (UP)",
            "Uttarakhand (UK)",
            "West Bengal (WB)",
            "Andaman and Nicobar Islands(AN)",
            "Chandigarh (CH)",
            "Dadra and Nagar Haveli (DN)",
            "Daman and Diu (DD)",
            "National Capital Territory of Delhi (DL)",
            "Lakshadweep (LD)",
            "Pondicherry (PY)"});
            this.cbState.Location = new System.Drawing.Point(111, 45);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(105, 21);
            this.cbState.TabIndex = 15;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Location = new System.Drawing.Point(152, 108);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(146, 20);
            this.tbContactNumber.TabIndex = 24;
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(274, 41);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(100, 20);
            this.tbPIN.TabIndex = 23;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(273, 15);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 22;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(111, 75);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(187, 20);
            this.tbEmail.TabIndex = 21;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(111, 15);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(100, 20);
            this.tbStreet.TabIndex = 20;
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStreet.Location = new System.Drawing.Point(21, 13);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(53, 20);
            this.lbStreet.TabIndex = 19;
            this.lbStreet.Text = "Street";
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCity.Location = new System.Drawing.Point(232, 13);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(35, 20);
            this.lbCity.TabIndex = 18;
            this.lbCity.Text = "City";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbState.Location = new System.Drawing.Point(21, 43);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(48, 20);
            this.lbState.TabIndex = 17;
            this.lbState.Text = "State";
            // 
            // lbPIN
            // 
            this.lbPIN.AutoSize = true;
            this.lbPIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPIN.Location = new System.Drawing.Point(233, 43);
            this.lbPIN.Name = "lbPIN";
            this.lbPIN.Size = new System.Drawing.Size(35, 20);
            this.lbPIN.TabIndex = 16;
            this.lbPIN.Text = "PIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contact Number";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(21, 73);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(53, 20);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "E-Mail";
            // 
            // btResetStudentData
            // 
            this.btResetStudentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResetStudentData.Location = new System.Drawing.Point(368, 384);
            this.btResetStudentData.Name = "btResetStudentData";
            this.btResetStudentData.Size = new System.Drawing.Size(119, 38);
            this.btResetStudentData.TabIndex = 15;
            this.btResetStudentData.Text = "Reset";
            this.btResetStudentData.UseVisualStyleBackColor = true;
            this.btResetStudentData.Click += new System.EventHandler(this.btResetStudentData_Click);
            // 
            // NewStudentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 445);
            this.Controls.Add(this.btResetStudentData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plStudentBasicDetails);
            this.Controls.Add(this.btSubmitStudentData);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.menuStrip1);
            this.Name = "NewStudentEntry";
            this.Text = "NewStudentEntry";
            this.Load += new System.EventHandler(this.NewStudentEntry_Load);
            this.plStudentBasicDetails.ResumeLayout(false);
            this.plStudentBasicDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbStudentFirstName;
        private System.Windows.Forms.TextBox tbStudentFirstName;
        private System.Windows.Forms.Label lbStudentDOB;
        private System.Windows.Forms.DateTimePicker dtpStudentDOB;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btSubmitStudentData;
        private System.Windows.Forms.Label lbStudentLastName;
        private System.Windows.Forms.TextBox tbStudentLastName;
        private System.Windows.Forms.Panel plStudentBasicDetails;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbPIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btResetStudentData;
    }
}