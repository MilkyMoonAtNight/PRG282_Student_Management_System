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
            this.btnlogin.Location = new System.Drawing.Point(209, 222);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 23);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Log In!";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(247, 114);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(100, 20);
            this.txtfullname.TabIndex = 0;
            // 
            // txtstudentno
            // 
            this.txtstudentno.Location = new System.Drawing.Point(247, 144);
            this.txtstudentno.Name = "txtstudentno";
            this.txtstudentno.Size = new System.Drawing.Size(100, 20);
            this.txtstudentno.TabIndex = 1;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(148, 120);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(58, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "Username:";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(148, 148);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(79, 13);
            this.lblnumber.TabIndex = 4;
            this.lblnumber.Text = "Admin Number:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Register!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(148, 173);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(56, 13);
            this.lblpass.TabIndex = 7;
            this.lblpass.Text = "Password:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(247, 173);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // cbxPassShow
            // 
            this.cbxPassShow.AutoSize = true;
            this.cbxPassShow.Location = new System.Drawing.Point(249, 199);
            this.cbxPassShow.Name = "cbxPassShow";
            this.cbxPassShow.Size = new System.Drawing.Size(102, 17);
            this.cbxPassShow.TabIndex = 3;
            this.cbxPassShow.Text = "Show Password";
            this.cbxPassShow.UseVisualStyleBackColor = true;
            this.cbxPassShow.CheckedChanged += new System.EventHandler(this.cbxPassShow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
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

