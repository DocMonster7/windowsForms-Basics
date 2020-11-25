namespace StudentApp_WindowsForm_Version
{
    partial class Form1
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
            this.cbSelectOption = new System.Windows.Forms.ComboBox();
            this.lbSelectOption = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbSelectOption
            // 
            this.cbSelectOption.FormattingEnabled = true;
            this.cbSelectOption.Items.AddRange(new object[] {
            "New Student(Single Entry)",
            "New Student(Multiple Entry)",
            "View Existing Student"});
            this.cbSelectOption.Location = new System.Drawing.Point(364, 136);
            this.cbSelectOption.Name = "cbSelectOption";
            this.cbSelectOption.Size = new System.Drawing.Size(202, 21);
            this.cbSelectOption.TabIndex = 0;
            // 
            // lbSelectOption
            // 
            this.lbSelectOption.AutoSize = true;
            this.lbSelectOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectOption.Location = new System.Drawing.Point(223, 137);
            this.lbSelectOption.Name = "lbSelectOption";
            this.lbSelectOption.Size = new System.Drawing.Size(135, 20);
            this.lbSelectOption.TabIndex = 1;
            this.lbSelectOption.Text = "Select A Option";
            // 
            // btSubmit
            // 
            this.btSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(364, 227);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(105, 42);
            this.btSubmit.TabIndex = 2;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.lbSelectOption);
            this.Controls.Add(this.cbSelectOption);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectOption;
        private System.Windows.Forms.Label lbSelectOption;
        private System.Windows.Forms.Button btSubmit;
    }
}

