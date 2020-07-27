﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Student_Management_System.DAL;
using Student_Management_System.Models;

namespace Student_Management_System.Controllers
{
    public class StudentController : IController<Student>
    {
        private SchoolContext _context;
        public StudentController(SchoolContext context)
        {
            _context = context;
        }
        public void Add(Student myObject)
        {
            if ((myObject as Student).Id == null)
            {
                throw new Exception("Student doesn't have an unique id.");
            }
            _context.Students.Add(myObject as Student);
        }

        public void Delete(Student myObject)
        {
            foreach (var contextStudent in _context.Students)
            {
                if (contextStudent.Id == (myObject as Student).Id)
                {
                    _context.Students.Remove(myObject as Student);
                    return;
                }
            }

            throw new Exception("Student not found!");
        }

        public void Update(Student myObject)
        {
            foreach (var student in _context.Students)
            {
                var contextStudent = myObject as Student;
                if (student.Id == contextStudent.Id)
                {
                    contextStudent.FirstName = student.FirstName;
                    contextStudent.LastName = student.LastName;
                    contextStudent.Enrollments = student.Enrollments;
                }
            }
        }

        public List<Student> GetAll()
        {
            return _context.Students;
        }

        public void AddGrade(string studentId, string courseId, int grade)
        {
            foreach (var contextStudent in _context.Students)
            {
                if (contextStudent.Id == studentId)
                {
                    foreach (var enrollment in contextStudent.Enrollments)
                    {
                        if (enrollment.Course.CourseId == courseId)
                        {
                            enrollment.Grade = grade;
                            return;
                        }
                    }
                    throw new Exception("Student not enrolled to course!");
                }
            }
            throw new Exception("Student not existing in database!");
        }

        public double GetStudentAverageGrade(string id)
        {
            var numberOfGrades = 0;
            var gradesTotalValue = 0;

            foreach (var student in _context.Students)
            {
                if (student.Id == id)
                {
                    foreach (var enrollment in student.Enrollments)
                    {
                        gradesTotalValue = gradesTotalValue + enrollment.Grade ?? 0;
                        if (enrollment.Grade != null)
                        {
                            numberOfGrades++;
                        }
                    }
                }
            }

            return gradesTotalValue / numberOfGrades;
        }

        public int GetStudentNumberOfCredits(string id)
        {
            var numberOfCredits = 0;
            foreach (var student in _context.Students)
            {
                if (student.Id == id)
                {
                    foreach (var enrollment in student.Enrollments)
                    {
                        numberOfCredits = numberOfCredits + enrollment.Grade ?? 0 * enrollment.Course.Credits;
                    }
                }
            }

            return numberOfCredits;
        }

        public List<Student> GetStudentsOrderedByNumberOfCredits()
        {
            List<Student> orderedStudents = new List<Student>();

            _context.Students.ForEach(s => orderedStudents.Add(s));
            orderedStudents.Sort(new MyStudentsComparer());

            return orderedStudents;
        }

        private class MyStudentsComparer : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                var numberOfCredits_1 = 0;
                var numberOfCredits_2 = 0;

                foreach (var enrollment in x.Enrollments)
                {
                    numberOfCredits_1 = numberOfCredits_1 + enrollment.Grade ?? 0 * enrollment.Course.Credits;
                }

                foreach (var enrollment in y.Enrollments)
                {
                    numberOfCredits_2 = numberOfCredits_2 + enrollment.Grade ?? 0 * enrollment.Course.Credits;
                }

                if (numberOfCredits_1 > numberOfCredits_2)
                {
                    return -1;
                }
                else if(numberOfCredits_1 < numberOfCredits_2)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
