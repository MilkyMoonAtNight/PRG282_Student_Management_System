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
            this.cbxPassShow.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxPassShow.Location = new System.Drawing.Point(296, 117);
            this.cbxPassShow.Name = "cbxPassShow";
            this.cbxPassShow.Size = new System.Drawing.Size(122, 21);
            this.cbxPassShow.TabIndex = 2;
            this.cbxPassShow.Text = "Show Password";
            this.cbxPassShow.UseVisualStyleBackColor = true;
            this.cbxPassShow.CheckedChanged += new System.EventHandler(this.cbxPassShow_CheckedChanged);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(297, 96);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(121, 25);
            this.txtpass.TabIndex = 1;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblpass.Location = new System.Drawing.Point(178, 96);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(70, 17);
            this.lblpass.TabIndex = 14;
            this.lblpass.Text = "Password:";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblnumber.Location = new System.Drawing.Point(178, 71);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(108, 17);
            this.lblnumber.TabIndex = 13;
            this.lblnumber.Text = "Admin Number:";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblname.Location = new System.Drawing.Point(178, 43);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(73, 17);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Username:";
            // 
            // txtfullname
            // 
            this.txtfullname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtfullname.Location = new System.Drawing.Point(297, 38);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(121, 25);
            this.txtfullname.TabIndex = 0;
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnconfirm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnconfirm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnconfirm.Location = new System.Drawing.Point(265, 244);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(86, 24);
            this.btnconfirm.TabIndex = 17;
            this.btnconfirm.Text = "Confirm!";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // btnPict
            // 
            this.btnPict.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPict.Location = new System.Drawing.Point(197, 144);
            this.btnPict.Name = "btnPict";
            this.btnPict.Size = new System.Drawing.Size(204, 23);
            this.btnPict.TabIndex = 3;
            this.btnPict.Text = "<Select Picture>";
            this.btnPict.UseVisualStyleBackColor = true;
            this.btnPict.Click += new System.EventHandler(this.btnPict_Click);
            // 
            // pbxreg
            // 
            this.pbxreg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxreg.Location = new System.Drawing.Point(424, 38);
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
            this.lblfile.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblfile.Location = new System.Drawing.Point(178, 170);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(240, 24);
            this.lblfile.TabIndex = 20;
            this.lblfile.Text = "No File Chosen.";
            this.lblfile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblfile.Click += new System.EventHandler(this.lblfile_Click);
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblcourse.Location = new System.Drawing.Point(243, 189);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(108, 17);
            this.lblcourse.TabIndex = 21;
            this.lblcourse.Text = "Select your role:";
            // 
            // cmbRole
            // 
            this.cmbRole.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(181, 209);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(237, 25);
            this.cmbRole.TabIndex = 4;
            // 
            // lblnewnum
            // 
            this.lblnewnum.AutoSize = true;
            this.lblnewnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblnewnum.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblnewnum.Location = new System.Drawing.Point(333, 71);
            this.lblnewnum.Name = "lblnewnum";
            this.lblnewnum.Size = new System.Drawing.Size(50, 17);
            this.lblnewnum.TabIndex = 23;
            this.lblnewnum.Text = "000000";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(815, 360);
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