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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PRG282_Project.DataLayer
{
    //this class handles reading and writing to the textfile
    internal class FileHandler
    {
        //method that adds a new student to the text file
        public void AddStudent(string id,string name, string age, string course, frmMain form )
        { 
            InputValidation validation = new InputValidation();//create a new InputValidation object
            //validate the inputs using the validation methods in the InputValidation class
            bool noEmpty= validation.noEmptyFields(id,name,age,course);
            bool validStudentID = validation.isStudentIDValid(id, form.txtStudentID);
            bool validAge = validation.isAgeValid(age, form.txtAge);

            if (noEmpty == true && validStudentID == true && validAge == true) // if the inputs pass validation
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
                string[] lines = File.ReadAllLines(fileName);//reads the text file and stores each line in an array
                return lines;
            }
            else
            {
                MessageBox.Show("Error!The text file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        

        //Searching for the student then updating the information and writing the information back to the textfile
        public void updatedInformationRetrieval(int ID, string name, int Age, string course)
        {
            string file = "students.txt";
            // Read all lines from the file
            var lines = File.ReadAllLines(file).ToList();

            // Update the matching line
            for (int i = 0; i < lines.Count; i++)
            {
                var parts = lines[i].Split(',');
                if ((int.Parse(parts[0]) == ID ) || parts[1] == name || (int.Parse(parts[2]) == Age) || parts[3] == course ) 
                {
                    lines[i] = $"{ID},{name},{Age},{course}"; // Update line with new details
                    break;
                }
            }

            // Write the updated lines back to the file
            File.WriteAllLines(file, lines);
        }


    }
}
