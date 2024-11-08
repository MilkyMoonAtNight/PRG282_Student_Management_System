using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Student_Management_System.BusinessLogicLayer
{
    internal class StudentDataRepository
    {
        private List<string[]> studentList;
        private string path = @"..\..\Students\students.txt";

        //Contructor to read and process data from students.txt file once and make list available to other methods.
        public StudentDataRepository()
        {
            //Call method to load latest data from the student.txt file
            LoadStudentData();

        }

        //Method to parse data from student.txt file and split into List of arrays:
        private void LoadStudentData()
        {
            studentList = new List<string[]>();

            //Try, catch for File operations error handling
            try
            {
                string[] students = File.ReadAllLines(path);

                foreach (string student in students)
                {
                    string[] fields = student.Split(',');
                    studentList.Add(fields);
                }
            }

            //To catch cases where file doesn't exist.
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"The file is not found at the specified path: {path}.");
                Console.WriteLine($"Error details: {ex.Message}");
            }
            //Permission error
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"User does not have permission to access this file.");
                Console.WriteLine($"Error details: {ex.Message}");
            }
            //To catch any other exceptions that might occur.
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred. Details of error: {ex.Message}");
            }

        }

        //Method to return the student data:
        public List<string[]> GetStudentList()
        {
            return studentList;
        }

    }
}
