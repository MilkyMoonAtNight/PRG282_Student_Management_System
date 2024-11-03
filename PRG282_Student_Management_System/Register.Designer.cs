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
            this.cbxcourses = new System.Windows.Forms.ComboBox();
            this.lblnewnum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxreg)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPassShow
            // 
            this.cbxPassShow.AutoSize = true;
            this.cbxPassShow.Location = new System.Drawing.Point(297, 122);
            this.cbxPassShow.Name = "cbxPassShow";
            this.cbxPassShow.Size = new System.Drawing.Size(102, 17);
            this.cbxPassShow.TabIndex = 16;
            this.cbxPassShow.Text = "Show Password";
            this.cbxPassShow.UseVisualStyleBackColor = true;
            this.cbxPassShow.CheckedChanged += new System.EventHandler(this.cbxPassShow_CheckedChanged);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(297, 96);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(121, 20);
            this.txtpass.TabIndex = 15;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(178, 96);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(56, 13);
            this.lblpass.TabIndex = 14;
            this.lblpass.Text = "Password:";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(178, 71);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(87, 13);
            this.lblnumber.TabIndex = 13;
            this.lblnumber.Text = "Student Number:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(178, 43);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 13);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Full Name:";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(297, 37);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(121, 20);
            this.txtfullname.TabIndex = 10;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(265, 244);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 17;
            this.btnconfirm.Text = "Confirm!";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnPict
            // 
            this.btnPict.Location = new System.Drawing.Point(203, 145);
            this.btnPict.Name = "btnPict";
            this.btnPict.Size = new System.Drawing.Size(196, 23);
            this.btnPict.TabIndex = 18;
            this.btnPict.Text = "<Select Picture>";
            this.btnPict.UseVisualStyleBackColor = true;
            this.btnPict.Click += new System.EventHandler(this.btnPict_Click);
            // 
            // pbxreg
            // 
            this.pbxreg.Location = new System.Drawing.Point(424, 37);
            this.pbxreg.Name = "pbxreg";
            this.pbxreg.Size = new System.Drawing.Size(236, 230);
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
            this.lblfile.Location = new System.Drawing.Point(178, 171);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(240, 13);
            this.lblfile.TabIndex = 20;
            this.lblfile.Text = "No File Chosen.";
            this.lblfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblfile.Click += new System.EventHandler(this.lblfile_Click);
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Location = new System.Drawing.Point(252, 194);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(98, 13);
            this.lblcourse.TabIndex = 21;
            this.lblcourse.Text = "Select your course:";
            // 
            // cbxcourses
            // 
            this.cbxcourses.FormattingEnabled = true;
            this.cbxcourses.Location = new System.Drawing.Point(181, 210);
            this.cbxcourses.Name = "cbxcourses";
            this.cbxcourses.Size = new System.Drawing.Size(237, 21);
            this.cbxcourses.TabIndex = 22;
            // 
            // lblnewnum
            // 
            this.lblnewnum.AutoSize = true;
            this.lblnewnum.Location = new System.Drawing.Point(333, 71);
            this.lblnewnum.Name = "lblnewnum";
            this.lblnewnum.Size = new System.Drawing.Size(43, 13);
            this.lblnewnum.TabIndex = 23;
            this.lblnewnum.Text = "000000";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblnewnum);
            this.Controls.Add(this.cbxcourses);
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
            this.Name = "Register";
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
        private System.Windows.Forms.ComboBox cbxcourses;
        private System.Windows.Forms.Label lblnewnum;
    }
}