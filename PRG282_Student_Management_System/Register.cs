using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Student_Management_System
{
    public partial class Register : Form
    {
        string fileName;
        string path = @"E:\OneDrive - belgiumcampus.ac.za\2nd_Year\PRG282\PRG282_Project\PRG282_Student_Management_System\Login\studentlogin.txt";
        public Register()
        {
            InitializeComponent();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string[] numcheck = File.ReadAllLines(path);
                string fullname = txtfullname.Text;
                var rand = new Random();
                string studentno = Convert.ToString(rand.Next(999999, 100000));
                string pass = txtpass.Text;
                using (var sw = new StreamWriter(path, true))
                {
                    foreach (string s in numcheck)
                    {
                        if (s == studentno)
                        {
                            MessageBox.Show("Student number in use.", "This student number is already used, try logging in.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Conformation.", $"Fullname: {txtfullname.Text}, Student Numer: {txtstudentno.Text}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            sw.WriteLine($"{txtfullname},{txtstudentno},{txtpass}");
                            sw.Close();
                        }
                    }

                }
                Register register = new Register();
                register.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnPict_Click(object sender, EventArgs e)
        {
            Files.Filter = "PDF Files|*.pdf|JPEG Files|*.jpeg|PNG Files|*.png";

            if (Files.ShowDialog() == DialogResult.OK)
            {
                string originalFileName = Path.GetFileNameWithoutExtension(Files.FileName);
                string extension = Path.GetExtension(Files.FileName);
                lblfile.Text = Files.FileName;
                fileName = Path.GetFileName(Files.FileName);
                string destinationFolder = @"E:\OneDrive - belgiumcampus.ac.za\2nd_Year\PRG282\PRG282_Project\PRG282_Student_Management_System\Login\Pictures";
                string uniqueFileName = $"{originalFileName}_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";

                string destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                try
                {
                    if (MessageBox.Show($"Are you sure you want to upload {fileName}?", "Conformation.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Copy(Files.FileName, destinationPath, overwrite: true);
                        MessageBox.Show("File successfully saved to the new location.");
                        pbxreg.Image = Image.FromFile(destinationPath);
                        pbxreg.SizeMode = PictureBoxSizeMode.StretchImage;
                    }else
                    {
                        MessageBox.Show("File has not been saved.");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void lblfile_Click(object sender, EventArgs e)
        {

        }
    }
}
