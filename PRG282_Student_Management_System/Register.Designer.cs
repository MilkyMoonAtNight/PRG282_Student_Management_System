namespace PRG282_Student_Management_System
{
    partial class Register
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
            this.cbxPassShow = new System.Windows.Forms.CheckBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnPict = new System.Windows.Forms.Button();
            this.pbxreg = new System.Windows.Forms.PictureBox();
            this.Files = new System.Windows.Forms.OpenFileDialog();
            this.lblfile = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblnewnum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxreg)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPassShow
            // 
            this.cbxPassShow.AutoSize = true;
            this.cbxPassShow.Location = new System.Drawing.Point(446, 188);
            this.cbxPassShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPassShow.Name = "cbxPassShow";
            this.cbxPassShow.Size = new System.Drawing.Size(148, 24);
            this.cbxPassShow.TabIndex = 2;
            this.cbxPassShow.Text = "Show Password";
            this.cbxPassShow.UseVisualStyleBackColor = true;
            this.cbxPassShow.CheckedChanged += new System.EventHandler(this.cbxPassShow_CheckedChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(446, 148);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(180, 26);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(267, 148);
            this.lblpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(82, 20);
            this.lblpass.TabIndex = 14;
            this.lblpass.Text = "Password:";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(267, 109);
            this.lblnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(118, 20);
            this.lblnumber.TabIndex = 13;
            this.lblnumber.Text = "Admin Number:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(267, 66);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(87, 20);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Username:";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(446, 58);
            this.txtfullname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(180, 26);
            this.txtfullname.TabIndex = 0;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(397, 375);
            this.btnconfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(112, 35);
            this.btnconfirm.TabIndex = 17;
            this.btnconfirm.Text = "Confirm!";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnPict
            // 
            this.btnPict.Location = new System.Drawing.Point(305, 222);
            this.btnPict.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPict.Name = "btnPict";
            this.btnPict.Size = new System.Drawing.Size(294, 35);
            this.btnPict.TabIndex = 3;
            this.btnPict.Text = "<Select Picture>";
            this.btnPict.UseVisualStyleBackColor = true;
            this.btnPict.Click += new System.EventHandler(this.btnPict_Click);
            // 
            // pbxreg
            // 
            this.pbxreg.Location = new System.Drawing.Point(636, 58);
            this.pbxreg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbxreg.Name = "pbxreg";
            this.pbxreg.Size = new System.Drawing.Size(354, 354);
            this.pbxreg.TabIndex = 19;
            this.pbxreg.TabStop = false;
            this.pbxreg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Files
            // 
            this.Files.FileName = "Files";
            // 
            // lblfile
            // 
            this.lblfile.Location = new System.Drawing.Point(267, 262);
            this.lblfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(360, 20);
            this.lblfile.TabIndex = 20;
            this.lblfile.Text = "No File Chosen.";
            this.lblfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblfile.Click += new System.EventHandler(this.lblfile_Click);
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(378, 299);
            this.lblcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(122, 20);
            this.lblcourse.TabIndex = 21;
            this.lblcourse.Text = "Select your role:";
            // 
            // cmbRole
            // 
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(271, 322);
            this.cmbRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(354, 28);
            this.cmbRole.TabIndex = 4;
            // 
            // lblnewnum
            // 
            this.lblnewnum.AutoSize = true;
            this.lblnewnum.Location = new System.Drawing.Point(500, 109);
            this.lblnewnum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewnum.Name = "lblnewnum";
            this.lblnewnum.Size = new System.Drawing.Size(63, 20);
            this.lblnewnum.TabIndex = 23;
            this.lblnewnum.Text = "000000";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 554);
            this.Controls.Add(this.lblnewnum);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.pbxreg);
            this.Controls.Add(this.btnPict);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.cbxPassShow);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtfullname);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxreg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxPassShow;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnPict;
        private System.Windows.Forms.PictureBox pbxreg;
        private System.Windows.Forms.OpenFileDialog Files;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Label lblnewnum;
    }
}