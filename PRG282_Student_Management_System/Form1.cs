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
        string path = @"E:\OneDrive - belgiumcampus.ac.za\2nd_Year\PRG282\PRG282_Project\PRG282_Student_Management_System\Login\studentlogin.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain MainForm= new frmMain();
            MainForm.Show();
            
            //using (var sr = new StreamReader(path))
            //{
                
            //}
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
    }
}
