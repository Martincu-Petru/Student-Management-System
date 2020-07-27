using System;
using Student_Management_System.Controllers;
using Student_Management_System.DAL;
using Student_Management_System.Models;

namespace Student_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContext schoolContext = new SchoolContext();
            StudentController studentController = new StudentController(schoolContext);
        }
    }
}
