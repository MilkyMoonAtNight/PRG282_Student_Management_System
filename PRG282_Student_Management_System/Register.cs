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
        string destinationPath;
        string fileName;
        string path = @"Users\Users.txt";
        public Register()
        {
            InitializeComponent();
        }
        public string GenerateRandomNumber()
        {
            var rand = new Random();
            int number = rand.Next(100000, 1000000);
            lblnewnum.Text = number.ToString(); 
            return lblnewnum.Text;
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string[] numcheck = File.ReadAllLines(path);
                bool isDuplicate = false;

                foreach (string s in numcheck)
                {
                    if (s.Contains(lblnewnum.Text))
                    {
                        MessageBox.Show("Warning", "Sorry, this number is already in use. Click OK to create a new one.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        GenerateRandomNumber();  // Generate a new number if a duplicate is found
                        isDuplicate = true;
                        break;  // Exit the loop since we found a duplicate
                    }
                }

                // If no duplicates
                if (!isDuplicate)
                {
                    using (var sw = new StreamWriter(path, true))
                    {
                        MessageBox.Show($"Fullname: {txtfullname.Text}, Student Number: {lblnewnum.Text}","Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sw.WriteLine($"{txtfullname.Text.ToLower()},{lblnewnum.Text},{txtpass.Text},{cbxcourses.Text},{destinationPath}");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnPict_Click(object sender, EventArgs e)
        {
            Files.Filter = "JPEG Files|*.jpeg|PNG Files|*.png";

            if (Files.ShowDialog() == DialogResult.OK)
            {
                string originalFileName = Path.GetFileNameWithoutExtension(Files.FileName);
                string extension = Path.GetExtension(Files.FileName);
                lblfile.Text = Files.FileName;
                fileName = Path.GetFileName(Files.FileName);
                string destinationFolder = @"Users\Pictures\";
                string uniqueFileName = $"{originalFileName}_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";

                destinationPath = Path.Combine(destinationFolder, uniqueFileName);

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

        private void Register_Load(object sender, EventArgs e)
        {
            GenerateRandomNumber();
            cbxcourses.Items.Add("BIT: Batchelors of Information Tech");
            cbxcourses.Items.Add("BCOM: Batchelors of Computing"); 
        }

        private void cbxPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPassShow.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }

        }
    }
}
