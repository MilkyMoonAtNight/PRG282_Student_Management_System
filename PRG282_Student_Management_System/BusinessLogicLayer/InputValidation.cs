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
    {
        public bool DoesStudentIDExist(string id)
        {
            FileHandler fileHandler = new FileHandler();
            string[] lines = fileHandler.read();
            for (int i = 0; i <= lines.Length-1; i++)
            {
                if (lines[i].Contains(id))
                {
                    return true;
                }
            }
            return false;
        }
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
                return false;
            }
            
            return true;
        }

        public bool isAgeValid(string age, TextBox txtAge)
        {
            bool isValid=true;
            //loop through each character in the string and ensure that it contains a number
            foreach (char character in age)
            {
                if (character < '0' || character > '9')
                {
                    isValid = false;
                    break;
                }
                
                
                    int iage = int.Parse(age);//convert strin to int
                    //checks if the age is in a valid range
                    if (iage < 18 || iage >= 60)
                    {
                        isValid = false;
                    }

                
            }

            if (!isValid)
            {
                MessageBox.Show("Invalid age. Please enter a valid age.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Clear();
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
