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
                if(int.TryParse(student[2], out int age))
                {
                    totalAge += age;
                }

            }
            //use ternary operator to check if total students is greater than 0
            //If true - will return total age divided by total number of students to get avg age

            double AverageAge = totalStudents >0? totalAge / totalStudents :0;
            
            return (totalStudents, AverageAge);

        }
    }
}
