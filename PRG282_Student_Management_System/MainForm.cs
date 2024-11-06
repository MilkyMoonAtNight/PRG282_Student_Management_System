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
using PRG282_Student_Management_System.BusinessLogicLayer;
using PRG282_Student_Management_System.PresentationLayer;
using PRG282_Student_Management_System;

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

        private void frmMain_Load(object sender, EventArgs e)
        {
            //sets the default value of the combo box
            cmbCourse.SelectedIndex = 0;
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

            //calls the add student method in the file handler class
            fileHandler.AddStudent(studentInfo.StudentID, studentInfo.Name, studentInfo.Age, studentInfo.Course, this);
        }

        //View students button => calls View method, from ViewStudents Class in PresentationLayer.
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            //Clears dataTable rows, before displaying.
            table.Rows.Clear();
            
            ViewStudents viewStudents = new ViewStudents();

            //View() returns string [] List used to populate studentData list.
            List<string[]> studentData =viewStudents.View();

            //Loop over each element (student) in studentData List and adds to DataTable.
            foreach (string[] student in studentData)
            {
                table.Rows.Add(student);
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            grpbSummary.Visible = true;
            ViewSummary summary = new ViewSummary();
            //Call Calculate Summary method using view summary object to return TotalStudents count and avg age calculation results
            var(TotalStudents, AveAge) = summary.CalculateSummary();

            //add results to text boxes for display
            txtTotalStudents.Text = TotalStudents.ToString();
            txtAvgAge.Text = AveAge.ToString();

            Console.WriteLine("Total Students: " + TotalStudents);
            Console.WriteLine("Average Age: " + AveAge);


        }


        private void dgvDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get updated data from text boxes
            string StudentID = txtStudentID.Text;
            string Name = txtName.Text;
            string Age = txtAge.Text;
            string Course = cmbCourse.Text;

            //create object for Update student class to send the retrieved data
            FileHandler updateStudents = new FileHandler();

            updateStudents.updatedInformationRetrieval(StudentID, Name, Age, Course, this);

            
            updateStudents.ReloadDataGridView(dgvDisplay,bs);

            UserInput userInput = new UserInput(); //creates a userinput object
            userInput.CLearTextBoxes(this);//calls method from the userinput to clear text boxes

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FileHandler fh = new FileHandler();
            fh.DeleteStudent(this);

            UserInput userInput = new UserInput(); //creates a userinput object
            userInput.CLearTextBoxes(this);//calls method from the userinput to clear text boxes
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

        private void dgvDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Display selected studentinfo in textboxes

            int indexRow = e.RowIndex;//get selected row index

            DataGridViewRow row = dgvDisplay.Rows[indexRow];

            //pass data selected to textboxes
            txtStudentID.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAge.Text = row.Cells[2].Value.ToString();
            cmbCourse.Text = row.Cells[3].Value.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //getting the input that needs to be searched
            int StudentID = int.Parse(txtSearch.Text);

            //Creating object and sending input to search method
            FileHandler fileHandler = new FileHandler();
            fileHandler.Search(StudentID,dgvDisplay,bs);
        }

        
    }
}
