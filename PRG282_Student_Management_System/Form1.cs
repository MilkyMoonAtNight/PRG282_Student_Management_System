using PRG282_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Student_Management_System
{
    public partial class Form1 : Form
    {
        string path = @"..\..\Users\Users.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Use a flag to check if the user is found
                bool userFound = false;

                // Read the file line by line
                using (var sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        // Ensure there are enough parts before accessing them
                        if (parts.Length >= 5)
                        {
                            //fullname matches
                            if (parts[0].ToLower() == txtfullname.Text.ToLower())
                            {
                                userFound = true;

                                //admin number matches
                                if (parts[1] == txtstudentno.Text)
                                {

                                    //password matches
                                    if (parts[2] == txtpass.Text)
                                    {
                                        MessageBox.Show($"Welcome {txtfullname.Text}!", "Login Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        frmMain frmMain = new frmMain();
                                        this.Hide();//hides the login form
                                        frmMain.FormClosed += (s, args) => this.Close();// closes the login form when the main form closes
                                        frmMain.ShowDialog();// opens the main form
                                    }
                                    else
                                    {
                                        MessageBox.Show("Sorry, your password is incorrect.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Sorry, your student number is incorrect.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                                break; //user was found
                            }
                        }
                    }

                    //user wasn't found
                    if (!userFound)
                    {
                        MessageBox.Show("Sorry, your fullname is incorrect.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void cbxPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPassShow.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void pbxlogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
