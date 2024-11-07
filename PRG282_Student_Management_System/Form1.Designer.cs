namespace PRG282_Student_Management_System
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtstudentno = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog3 = new System.Windows.Forms.FolderBrowserDialog();
            this.cbxPassShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlogin.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(152, 180);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Log In!";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfullname
            // 
            this.txtfullname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtfullname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtfullname.Location = new System.Drawing.Point(205, 75);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(100, 25);
            this.txtfullname.TabIndex = 0;
            // 
            // txtstudentno
            // 
            this.txtstudentno.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtstudentno.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtstudentno.Location = new System.Drawing.Point(205, 102);
            this.txtstudentno.Name = "txtstudentno";
            this.txtstudentno.Size = new System.Drawing.Size(100, 25);
            this.txtstudentno.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(91, 78);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(73, 17);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Username:";
            this.lblname.UseMnemonic = false;
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblnumber.Location = new System.Drawing.Point(91, 102);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(108, 17);
            this.lblnumber.TabIndex = 4;
            this.lblnumber.Text = "Admin Number:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(152, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Register!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblpass.Location = new System.Drawing.Point(94, 128);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(70, 17);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "Password:";
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtpass.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtpass.Location = new System.Drawing.Point(205, 128);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 25);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // cbxPassShow
            // 
            this.cbxPassShow.AutoSize = true;
            this.cbxPassShow.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold);
            this.cbxPassShow.Location = new System.Drawing.Point(187, 154);
            this.cbxPassShow.Name = "cbxPassShow";
            this.cbxPassShow.Size = new System.Drawing.Size(131, 19);
            this.cbxPassShow.TabIndex = 3;
            this.cbxPassShow.Text = "Show Password";
            this.cbxPassShow.UseVisualStyleBackColor = true;
            this.cbxPassShow.CheckedChanged += new System.EventHandler(this.cbxPassShow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(447, 330);
            this.Controls.Add(this.cbxPassShow);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtstudentno);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.btnlogin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtstudentno;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog3;
        private System.Windows.Forms.CheckBox cbxPassShow;
    }
}

