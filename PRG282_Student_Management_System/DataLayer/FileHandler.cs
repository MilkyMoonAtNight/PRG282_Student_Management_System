using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//imports
using System.IO;
using PRG282_Project.BusinessLogicLayer;
using System.Windows.Forms;
using PRG282_Project.PresentationLayer;

namespace PRG282_Project.DataLayer
{
    //this class handles reading and writing to the textfile
    internal class FileHandler
    {

        public void AddStudent(string id,string name, string age, string course, frmMain form )
        { 


            InputValidation validation = new InputValidation();
            bool noEmpty= validation.noEmptyFields(id,name,age,course);
            bool validStudentID = validation.isStudentIDValid(id, form.txtStudentID);
            bool validAge = validation.isAgeValid(age, form.txtAge);

            if (noEmpty == true && validStudentID == true && validAge == true)
            {
                if (File.Exists("students.txt"))//test if the textfile exists
                {
                    string data = $"{id},{name},{age},{course}";
                    File.AppendAllText("students.txt", Environment.NewLine + data);//apppends the student data to the students textfile

                    //test if student has been added
                    if (validation.DoesStudentIDExist(id) == true)
                    {
                        MessageBox.Show($"{name} has succssefully been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    
                }
                else
                {
                    MessageBox.Show("Error!The text file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            
        }

        //reads all the lines of the textfile into an array
        public string[] read()
        {
            string fileName = "students.txt";
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                return lines;
            }
            else
            {
                MessageBox.Show("Error!The text file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }
    }
}
