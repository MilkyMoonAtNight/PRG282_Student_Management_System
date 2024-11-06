using PRG282_Student_Management_System.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Student_Management_System.PresentationLayer
{
    internal class ViewSummary
    {
        
        public (int TotalStudents, double AvgAge) CalculateSummary()
        
        {
            //access latest data from student.txt file using student repository methods from StudentData class
            //Create StudentDataRepository instance to ensure latest data from text file is loading, whilst app is running
            StudentDataRepository repository = new StudentDataRepository();

            //Create list from this instance to be able to calculate latest student count and avg age
            List<string[]> studentList = repository.GetStudentList();

            int totalStudents = studentList.Count;
            int totalAge = 0;

            foreach (string[] student in studentList)
            {
                //checks if each student entry has all fields, to avoid "index out of bounds" exeption.
                //use TryParse to convert student age (found at index 2) to an integer and add age to totalAge variable.
                if(student.Length > 2 && int.TryParse(student[2], out int age))
                {
                    totalAge += age;
                }

            }
            //use ternary operator to check if total students is greater than 0 (because division by 0 will cause an error.
            //If true - will return total age divided by total number of students to get avg age
            //If false will return '0'.
            
            //Cast totalAge to double to ensure answer can be calculated with decimal precision (else dividing two integers will result in an integer answer and the average
            //might not be an integer).
            //Math.Round method used to round the AverageAge value to three decimal places.
            double AverageAge = totalStudents >0? Math.Round((double)totalAge/totalStudents,3) :0;


            string summaryPath = "summary.txt";

            using (StreamWriter writer = new StreamWriter(summaryPath))
            {
                writer.WriteLine("Summary of Student data:");
                writer.WriteLine("==================================");
                writer.WriteLine($"Total students: {totalStudents}");
                writer.WriteLine($"Average age of students: {AverageAge}");
                writer.WriteLine("==================================");
            }



            return (totalStudents, AverageAge);



        }
    }
}
