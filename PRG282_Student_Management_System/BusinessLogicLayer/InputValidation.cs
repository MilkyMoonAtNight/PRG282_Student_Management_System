using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//imports
using System.IO;
using System.Windows.Forms;
using PRG282_Project.DataLayer;



namespace PRG282_Project.BusinessLogicLayer
{
    internal class InputValidation
    {//method that tests if the student id is already in the text file
        public bool DoesStudentIDExist(string id)
        {
            try
            {
                FileHandler fileHandler = new FileHandler();
                //reads all the lines from the text file into an array
                string[] lines = fileHandler.read();
                //loops through the array and checks if the  id is already in the array
                foreach (string line in lines)
                {
                    if (line.Contains(id))
                    {
                        return true;
                    }
                }
            }
            catch (IOException ex)// throws an exception if there was a problem when reading from the text file
            {
                MessageBox.Show("Error reading the student file. " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        //method that tests if the student id only contains numbers
        public bool isStudentIDValid(string id, TextBox txtStudentID)
        {
            foreach (char character in id)
            {
                if (character < '0' || character > '9')
                {
                    MessageBox.Show("Invalid Student ID. Please enter a valid student ID Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtStudentID.Clear();
                    return false;
                    
                }
            }
            //show error if the student number already exists
            if (DoesStudentIDExist(id) == true)
            {
                MessageBox.Show("This student ID already exists. Please ensure you have entered the correct student id number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStudentID.Clear();
                return false;
            }
            
            return true;
        }

        //method that tests if the age is an integer and that the age is between 18 and 100
        public bool isAgeValid(string age, TextBox txtAge)
        {
            try
            {
                int iAge = int.Parse(age);
                //tests if the age is in the valid range
                if (iAge < 18 || iAge >= 100)
                {
                    MessageBox.Show("Invalid age. Please enter a valid age.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAge.Clear();
                    return false;
                }
            }
            catch (FormatException) //throws an exception if age is not a valid integer
            {
                MessageBox.Show("Invalid age format. Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Clear();
                return false;
            }
            return true;
        }

        //method that makes sure that the full name contains a space and does not contain a ,
        public bool isFullNameValid(string name, TextBox txtName) 
        {
            if (!name.Contains(' ') || name.Contains(','))
            {
                MessageBox.Show("Invalid full name. Please ensure that your full name contains a space and does not contain a comma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Clear();
                return false;
            }
            return true;
        }

        // method to make sure that there are no empty fields
        public bool noEmptyFields(string id, string name, string age, string course)
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(course))
            {
                MessageBox.Show("Please fill in all fields.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }

     

    }
}
