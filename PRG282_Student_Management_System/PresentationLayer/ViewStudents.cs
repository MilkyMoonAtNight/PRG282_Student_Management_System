using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_Student_Management_System.BusinessLogicLayer
{
    internal class ViewStudents
    {

        //Method to View data from student.txt, using StudentData class methods for centralised reading and parsing of file data
        public List<string[]> View()
        {
            //Create StudentDataRepository instance to ensure latest data from text file is loading, whilst app is running
            StudentDataRepository repository = new StudentDataRepository();
            return repository.GetStudentList();
        }  
    
    }
}
