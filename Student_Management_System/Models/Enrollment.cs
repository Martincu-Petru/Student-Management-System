﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Student_Management_System.Models
{
    public class Enrollment
    {
        public string EnrollmentId { get; set; }
        public int? Grade { get; set; }
        public Course Course { get; set; }
    }
}
