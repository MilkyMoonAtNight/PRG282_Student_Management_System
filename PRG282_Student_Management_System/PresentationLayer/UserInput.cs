﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static PRG282_Project.frmMain;

namespace PRG282_Project.PresentationLayer
{
    internal class UserInput
    {


        public StudentInfo GetInput(frmMain form)
        {
            return new StudentInfo
            {
                StudentID = form.txtStudentID.Text,
                Name = form.txtName.Text,
                Age = form.txtAge.Text,
                Course = form.txtCourse.Text
            };
        }
        //method to clear all text boxes
        public void CLearTextBoxes(frmMain form)
        {
            form.txtName.Clear();
            form.txtStudentID.Clear();
            form.txtAge.Clear();
            form.txtCourse.Clear();
        }

    }
}
