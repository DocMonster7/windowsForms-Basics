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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentSingleEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentMultipleEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExistingStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbStudentEntry = new System.Windows.Forms.Label();
            this.tbStudentEntry = new System.Windows.Forms.TextBox();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.lbStudentDOB = new System.Windows.Forms.Label();
            this.dtpStudentDOB = new System.Windows.Forms.DateTimePicker();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btSubmitStudentData = new System.Windows.Forms.Button();
            this.btDone = new System.Windows.Forms.Button();
            this.lbCounter = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentSingleEntryToolStripMenuItem,
            this.newStudentMultipleEntryToolStripMenuItem,
            this.viewExistingStudentToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // newStudentSingleEntryToolStripMenuItem
            // 
            this.newStudentSingleEntryToolStripMenuItem.Name = "newStudentSingleEntryToolStripMenuItem";
            this.newStudentSingleEntryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.newStudentSingleEntryToolStripMenuItem.Text = "New Student(Single Entry)";
            this.newStudentSingleEntryToolStripMenuItem.Click += new System.EventHandler(this.newStudentSingleEntryToolStripMenuItem_Click_1);
            // 
            // newStudentMultipleEntryToolStripMenuItem
            // 
            this.newStudentMultipleEntryToolStripMenuItem.Name = "newStudentMultipleEntryToolStripMenuItem";
            this.newStudentMultipleEntryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.newStudentMultipleEntryToolStripMenuItem.Text = "New Student(Multiple Entry)";
            this.newStudentMultipleEntryToolStripMenuItem.Click += new System.EventHandler(this.newStudentMultipleEntryToolStripMenuItem_Click_1);
            // 
            // viewExistingStudentToolStripMenuItem
            // 
            this.viewExistingStudentToolStripMenuItem.Name = "viewExistingStudentToolStripMenuItem";
            this.viewExistingStudentToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.viewExistingStudentToolStripMenuItem.Text = "View Existing Student";
            this.viewExistingStudentToolStripMenuItem.Click += new System.EventHandler(this.viewExistingStudentToolStripMenuItem_Click_1);
            // 
            // lbStudentEntry
            // 
            this.lbStudentEntry.AutoSize = true;
            this.lbStudentEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentEntry.Location = new System.Drawing.Point(146, 76);
            this.lbStudentEntry.Name = "lbStudentEntry";
            this.lbStudentEntry.Size = new System.Drawing.Size(198, 20);
            this.lbStudentEntry.TabIndex = 1;
            this.lbStudentEntry.Text = "Enter Number Of Students";
            this.lbStudentEntry.Visible = false;
            // 
            // tbStudentEntry
            // 
            this.tbStudentEntry.Location = new System.Drawing.Point(381, 78);
            this.tbStudentEntry.Name = "tbStudentEntry";
            this.tbStudentEntry.Size = new System.Drawing.Size(100, 20);
            this.tbStudentEntry.TabIndex = 2;
            this.tbStudentEntry.Visible = false;
            // 
            // lbStudentName
            // 
            this.lbStudentName.AutoSize = true;
            this.lbStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.Location = new System.Drawing.Point(189, 118);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(155, 20);
            this.lbStudentName.TabIndex = 3;
            this.lbStudentName.Text = "Enter Student Name";
            this.lbStudentName.Visible = false;
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(381, 118);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(100, 20);
            this.tbStudentName.TabIndex = 4;
            this.tbStudentName.Visible = false;
            // 
            // lbStudentDOB
            // 
            this.lbStudentDOB.AutoSize = true;
            this.lbStudentDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentDOB.Location = new System.Drawing.Point(242, 159);
            this.lbStudentDOB.Name = "lbStudentDOB";
            this.lbStudentDOB.Size = new System.Drawing.Size(102, 20);
            this.lbStudentDOB.TabIndex = 5;
            this.lbStudentDOB.Text = "Date Of Birth";
            this.lbStudentDOB.Visible = false;
            // 
            // dtpStudentDOB
            // 
            this.dtpStudentDOB.Location = new System.Drawing.Point(381, 158);
            this.dtpStudentDOB.Name = "dtpStudentDOB";
            this.dtpStudentDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpStudentDOB.TabIndex = 6;
            this.dtpStudentDOB.Visible = false;
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
            this.btSubmitStudentData.Location = new System.Drawing.Point(381, 234);
            this.btSubmitStudentData.Name = "btSubmitStudentData";
            this.btSubmitStudentData.Size = new System.Drawing.Size(119, 38);
            this.btSubmitStudentData.TabIndex = 8;
            this.btSubmitStudentData.Text = "Submit";
            this.btSubmitStudentData.UseVisualStyleBackColor = true;
            this.btSubmitStudentData.Visible = false;
            this.btSubmitStudentData.Click += new System.EventHandler(this.btSubmitStudentData_Click);
            // 
            // btDone
            // 
            this.btDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDone.Location = new System.Drawing.Point(517, 76);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(98, 25);
            this.btDone.TabIndex = 9;
            this.btDone.Text = "Done";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Visible = false;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.BackColor = System.Drawing.SystemColors.Highlight;
            this.lbCounter.Location = new System.Drawing.Point(381, 215);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(31, 13);
            this.lbCounter.TabIndex = 10;
            this.lbCounter.Text = "none";
            this.lbCounter.Visible = false;
            // 
            // NewStudentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 445);
            this.Controls.Add(this.lbCounter);
            this.Controls.Add(this.btDone);
            this.Controls.Add(this.btSubmitStudentData);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dtpStudentDOB);
            this.Controls.Add(this.lbStudentDOB);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.lbStudentName);
            this.Controls.Add(this.tbStudentEntry);
            this.Controls.Add(this.lbStudentEntry);
            this.Controls.Add(this.menuStrip1);
            this.Name = "NewStudentEntry";
            this.Text = "NewStudentEntry";
            this.Load += new System.EventHandler(this.NewStudentEntry_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentSingleEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentMultipleEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExistingStudentToolStripMenuItem;
        private System.Windows.Forms.Label lbStudentEntry;
        private System.Windows.Forms.TextBox tbStudentEntry;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label lbStudentDOB;
        private System.Windows.Forms.DateTimePicker dtpStudentDOB;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btSubmitStudentData;
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.Label lbCounter;
    }
}