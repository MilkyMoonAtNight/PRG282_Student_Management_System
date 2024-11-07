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
        string path = @"..\..\Users\Users.txt";
        
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
            // Validation for empty fields
            if (string.IsNullOrWhiteSpace(txtfullname.Text))
            {
                MessageBox.Show("Full name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfullname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpass.Text))
            {
                MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpass.Focus();
                return;
            }

            if (lblfile.Text == "No File Chosen.")
            {
                MessageBox.Show("No file selected. Please select a file before confirming.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Role must be selected from the dropdown.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return;
            }

            try
            {
                string[] numcheck = File.ReadAllLines(path);
                bool isDuplicate = false;

                foreach (string s in numcheck)
                {
                    if (s.Contains(lblnewnum.Text))
                    {
                        MessageBox.Show("Sorry, this number is already in use. Click OK to create a new one.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show($"Registration successful:\nFullname: {txtfullname.Text}, Admin Number: {lblnewnum.Text}", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sw.WriteLine($"{txtfullname.Text.ToLower()},{lblnewnum.Text},{txtpass.Text},{cmbRole.Text},{destinationPath}");
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

                // Use the current user's Pictures folder for a reliable destination
                string destinationFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                string uniqueFileName = $"{originalFileName}_{DateTime.Now:yyyyMMdd_HHmmss}{extension}";

                destinationPath = Path.Combine(destinationFolder, uniqueFileName);

                try
                {
                    if (MessageBox.Show($"Are you sure you want to upload {fileName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        File.Copy(Files.FileName, destinationPath, overwrite: true);
                        MessageBox.Show("File successfully saved to the new location.");

                        // Set the PictureBox image using ImageLocation to avoid file lock issues
                        pbxreg.ImageLocation = destinationPath;
                        pbxreg.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
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
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Lecturer"); 
            cmbRole.SelectedIndex = 0;
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
