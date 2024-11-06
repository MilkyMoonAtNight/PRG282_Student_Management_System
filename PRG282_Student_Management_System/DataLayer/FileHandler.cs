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
using static System.Windows.Forms.LinkLabel;
using System.IO.Ports;
using System.Drawing;
using PRG282_Student_Management_System.BusinessLogicLayer;
using System.Data;

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

            string fileName = @"..\..\Students\students.txt";
            if (noEmpty == true && validStudentID == true && validAge == true) // if the inputs pass validation
            {
                if (File.Exists(fileName))//test if the textfile exists
                {
                    string data = $"{id},{name},{age},{course}";
                    File.AppendAllText(fileName, Environment.NewLine + data);//apppends the student data to the students textfile

                    //test if student has been added
                    if (validation.DoesStudentIDExist(id) == true)
                    {
                        MessageBox.Show($"{name} has succssefully been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    
                }
                else
                {//display error message
                    MessageBox.Show("Error!The text file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //reads all the lines of the textfile into an array
        public string[] read()
        {
            string fileName = @"..\..\Students\students.txt";
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





        //Searching for student ID to highlight student information in datagrid
        public void Search(int IDSearch,DataGridView datagrid) 
        {
            //put file path in a variable
            string filepath = @"..\..\Students\students.txt";

            // Read all lines from the file and add it to a list
            var line = File.ReadAllLines(filepath).ToList();//.to list creates a list

            // looping through all the lines
            for (int i = 0; i < line.Count; i++)
            {
                var parts = line[i].Split(',');

                // Ensure the line has the correct number of parts 
                if (parts.Length == 4)
                {

                    if (int.Parse(parts[0]) == IDSearch)
                    {
                        // Highlight the row searched by setting the background color to yellow
                        datagrid.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    }
                }
            }



        }





            //Searching for the student then updating the information and writing the information back to the textfile
            public  void updatedInformationRetrieval(int ID, string name, int Age, string course)
        {
            //put file path in a variable
            string file = @"..\..\Students\students.txt";

            // Read all lines from the file and add it to a list
            var lines = File.ReadAllLines(file).ToList();//.to list creates a list


                // Update the matching line,looping through all the lines
                for (int i = 0; i < lines.Count; i++)
                {
                var parts = lines[i].Split(',');

                // Ensure the line has the correct number of parts 
                if (parts.Length == 4)
                {
                   
                    if (int.Parse(parts[0]) == ID)
                    {
                        lines[i] = $"{ID},{name},{Age},{course}"; // Update line with new details
                        break;
                    }
                }
            }

            // Write the updated lines back to the file
            File.WriteAllLines(file, lines);

            
              }



        public void ReloadDataGridView(DataGridView dgvDisplay, BindingSource bs)
        {
            // Get the DataTable from the BindingSource
            DataTable table = (DataTable)bs.DataSource;
            // Clear existing rows in the DataTable 
            table.Rows.Clear();

            // Get the updated student data from the file
            ViewStudents viewStudents = new ViewStudents();
            List<string[]> studentData = viewStudents.View();

            // Loop through each student and add to the DataGridView
            foreach (string[] student in studentData)
            {
                table.Rows.Add(student); // Adds each student to the DataTable
            }

            // Refresh the DataGridView to reflect the changes
            dgvDisplay.Refresh();
        }

        public void DeleteStudent(frmMain form)
        {
            string file = @"..\..\Students\students.txt";

            if (File.Exists(file)) // Check if file exists
            {
                InputValidation iv = new InputValidation();
                string id = form.txtStudentID.Text;
                string name = form.txtName.Text;
                string age = form.txtAge.Text;
                string course = form.txtCourse.Text;

                bool notnull = iv.noEmptyFields(id, name, age, course); // true if no empty fields
                if (notnull)
                {
                    List<string> lines = File.ReadAllLines(file).ToList();

                    // Remove lines where the first column (ID) matches ID
                    lines.RemoveAll(line => line.Split(',')[0] == id);

                    // Write the remaining lines back to the file
                    File.WriteAllLines(file, lines);
                    MessageBox.Show($"Delete successful. {name} was deleted.");

                }
                else
                {
                    MessageBox.Show("Please select a student with all fields.");
                }
            }
        }










    }
}
