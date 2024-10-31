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
            this.txtstudentno = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.btnconfirm = new System.Windows.Forms.Button();
            this.btnPict = new System.Windows.Forms.Button();
            this.pbxreg = new System.Windows.Forms.PictureBox();
            this.Files = new System.Windows.Forms.OpenFileDialog();
            this.lblfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxreg)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxPassShow
            // 
            this.cbxPassShow.AutoSize = true;
            this.cbxPassShow.Location = new System.Drawing.Point(290, 196);
            this.cbxPassShow.Name = "cbxPassShow";
            this.cbxPassShow.Size = new System.Drawing.Size(102, 17);
            this.cbxPassShow.TabIndex = 16;
            this.cbxPassShow.Text = "Show Password";
            this.cbxPassShow.UseVisualStyleBackColor = true;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(288, 170);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 15;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(189, 170);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(56, 13);
            this.lblpass.TabIndex = 14;
            this.lblpass.Text = "Password:";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(189, 145);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(87, 13);
            this.lblnumber.TabIndex = 13;
            this.lblnumber.Text = "Student Number:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(189, 117);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(57, 13);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Full Name:";
            // 
            // txtstudentno
            // 
            this.txtstudentno.Location = new System.Drawing.Point(288, 142);
            this.txtstudentno.Name = "txtstudentno";
            this.txtstudentno.Size = new System.Drawing.Size(100, 20);
            this.txtstudentno.TabIndex = 11;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(288, 111);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(100, 20);
            this.txtfullname.TabIndex = 10;
            // 
            // btnconfirm
            // 
            this.btnconfirm.Location = new System.Drawing.Point(251, 268);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(75, 23);
            this.btnconfirm.TabIndex = 17;
            this.btnconfirm.Text = "Confirm!";
            this.btnconfirm.UseVisualStyleBackColor = true;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnPict
            // 
            this.btnPict.Location = new System.Drawing.Point(192, 219);
            this.btnPict.Name = "btnPict";
            this.btnPict.Size = new System.Drawing.Size(196, 23);
            this.btnPict.TabIndex = 18;
            this.btnPict.Text = "<Select Picture>";
            this.btnPict.UseVisualStyleBackColor = true;
            this.btnPict.Click += new System.EventHandler(this.btnPict_Click);
            // 
            // pbxreg
            // 
            this.pbxreg.Location = new System.Drawing.Point(398, 111);
            this.pbxreg.Name = "pbxreg";
            this.pbxreg.Size = new System.Drawing.Size(172, 180);
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
            this.lblfile.Location = new System.Drawing.Point(189, 245);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(200, 13);
            this.lblfile.TabIndex = 20;
            this.lblfile.Text = "No File Chosen.";
            this.lblfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblfile.Click += new System.EventHandler(this.lblfile_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblfile);
            this.Controls.Add(this.pbxreg);
            this.Controls.Add(this.btnPict);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.cbxPassShow);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtstudentno);
            this.Controls.Add(this.txtfullname);
            this.Name = "Register";
            this.Text = "Register";
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
        private System.Windows.Forms.TextBox txtstudentno;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Button btnPict;
        private System.Windows.Forms.PictureBox pbxreg;
        private System.Windows.Forms.OpenFileDialog Files;
        private System.Windows.Forms.Label lblfile;
    }
}