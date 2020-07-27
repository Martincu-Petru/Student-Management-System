using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System.Models
{
    public class Student
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
