namespace StudentApp_WindowsForm_Version
{
    partial class ViewStudent
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbRegisterNumber = new System.Windows.Forms.Label();
            this.tbRegisterNumber = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.dgvStudentTable = new System.Windows.Forms.DataGridView();
            this.btViewAll = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentSingleEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStudentMultipleEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbStatus.Location = new System.Drawing.Point(377, 48);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(31, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "none";
            this.lbStatus.Visible = false;
            this.lbStatus.Click += new System.EventHandler(this.lbStatus_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(309, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(190, 25);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "All Student Details";
            this.lbTitle.Click += new System.EventHandler(this.lbTitle_Click);
            // 
            // lbRegisterNumber
            // 
            this.lbRegisterNumber.AutoSize = true;
            this.lbRegisterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegisterNumber.Location = new System.Drawing.Point(28, 61);
            this.lbRegisterNumber.Name = "lbRegisterNumber";
            this.lbRegisterNumber.Size = new System.Drawing.Size(247, 18);
            this.lbRegisterNumber.TabIndex = 4;
            this.lbRegisterNumber.Text = "Enter Student Register Number ";
            this.lbRegisterNumber.Visible = false;
            this.lbRegisterNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbRegisterNumber
            // 
            this.tbRegisterNumber.Location = new System.Drawing.Point(281, 61);
            this.tbRegisterNumber.Name = "tbRegisterNumber";
            this.tbRegisterNumber.Size = new System.Drawing.Size(171, 20);
            this.tbRegisterNumber.TabIndex = 5;
            this.tbRegisterNumber.Visible = false;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(475, 52);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(99, 35);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Visible = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // dgvStudentTable
            // 
            this.dgvStudentTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStudentTable.Location = new System.Drawing.Point(168, 103);
            this.dgvStudentTable.Name = "dgvStudentTable";
            this.dgvStudentTable.Size = new System.Drawing.Size(494, 212);
            this.dgvStudentTable.TabIndex = 7;
            this.dgvStudentTable.Visible = false;
            // 
            // btViewAll
            // 
            this.btViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewAll.Location = new System.Drawing.Point(591, 52);
            this.btViewAll.Name = "btViewAll";
            this.btViewAll.Size = new System.Drawing.Size(94, 35);
            this.btViewAll.TabIndex = 9;
            this.btViewAll.Text = "View All";
            this.btViewAll.UseVisualStyleBackColor = true;
            this.btViewAll.Visible = false;
            this.btViewAll.Click += new System.EventHandler(this.btViewAll_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStudentSingleEntryToolStripMenuItem,
            this.newStudentMultipleEntriesToolStripMenuItem,
            this.viewStudentsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // newStudentSingleEntryToolStripMenuItem
            // 
            this.newStudentSingleEntryToolStripMenuItem.Name = "newStudentSingleEntryToolStripMenuItem";
            this.newStudentSingleEntryToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.newStudentSingleEntryToolStripMenuItem.Text = "New Student (Single Entry)";
            this.newStudentSingleEntryToolStripMenuItem.Click += new System.EventHandler(this.newStudentSingleEntryToolStripMenuItem_Click);
            // 
            // newStudentMultipleEntriesToolStripMenuItem
            // 
            this.newStudentMultipleEntriesToolStripMenuItem.Name = "newStudentMultipleEntriesToolStripMenuItem";
            this.newStudentMultipleEntriesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.newStudentMultipleEntriesToolStripMenuItem.Text = "New Student(Multiple Entries";
            this.newStudentMultipleEntriesToolStripMenuItem.Click += new System.EventHandler(this.newStudentMultipleEntriesToolStripMenuItem_Click);
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btViewAll);
            this.Controls.Add(this.dgvStudentTable);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbRegisterNumber);
            this.Controls.Add(this.lbRegisterNumber);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewStudent";
            this.Text = "ViewStudent";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbRegisterNumber;
        private System.Windows.Forms.TextBox tbRegisterNumber;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridView dgvStudentTable;
        private System.Windows.Forms.Button btViewAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentSingleEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStudentMultipleEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
    }
}