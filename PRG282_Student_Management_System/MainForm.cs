using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using PRG282_Project.DataLayer;
using PRG282_Project.PresentationLayer;

namespace PRG282_Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();//initiate a new binding source
        DataTable table = new DataTable(); //initiate a new table
        int IndexValue = 0;
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Create a table when form loads
            table.Columns.Add("Student ID",typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Age", typeof(decimal));
            table.Columns.Add("Course", typeof(string));

            //display the table in the grid view
            bs.DataSource = table;
            dgvDisplay.DataSource = bs;

        }
        //class that contains all the sutdents information
        public class StudentInfo
        {
            //fields
            public string StudentID { get; set; }
            public string Name { get; set; }
            public string Age { get; set; }
            public string Course { get; set; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            FileHandler fileHandler = new FileHandler();//create a filehandler object
            UserInput userInput = new UserInput(); //creates a userinput object
            StudentInfo studentInfo = userInput.GetInput(this); //stores the inputs in the studentinfo class


            //calls the add student method in the file handler class --> use the fields from the
            fileHandler.AddStudent(studentInfo.StudentID, studentInfo.Name, studentInfo.Age, studentInfo.Course, this);

            //calls method from the userinput to clear text boxes
            userInput.CLearTextBoxes(this);

            
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

        }


        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        //method moves to the previous entry in the data grid view table
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
        }
        //method moves to the next entry in the data grid view table
        private void btnNext_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
        }
    }
}
