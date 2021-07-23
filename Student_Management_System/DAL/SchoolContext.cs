using System.Collections.Generic;
using Student_Management_System.Models;

namespace Student_Management_System.DAL
{
    public class SchoolContext
    {
        public SchoolContext()
        {
            var students = new List<Student>
            {
                new Student{Id = "60f6a6fc-9de7-4fca-b75c-f6f335c76961", FirstName="Carson",LastName="Alexander", Enrollments = new List<Enrollment>()},
                new Student{Id = "f062e0d5-5aab-4ddf-8ac8-fed2053c6202", FirstName="Meredith",LastName="Alonso", Enrollments = new List<Enrollment>()},
                new Student{Id = "d3d8e6fd-cc8e-41e7-94c3-8b9d2ae4e4a7", FirstName="Arturo",LastName="Anand", Enrollments = new List<Enrollment>()},
                new Student{Id = "62df9945-02e9-4880-a630-5868c9a802c2", FirstName="Gytis",LastName="Barzdukas", Enrollments = new List<Enrollment>()},
                new Student{Id = "87d64e8e-102b-4c14-9532-cc1b2a4c8517", FirstName="Yan",LastName="Li", Enrollments = new List<Enrollment>()},
                new Student{Id = "5fd30b29-0881-489a-8f3f-33ebfe09e406", FirstName="Peggy",LastName="Justice", Enrollments = new List<Enrollment>()},
                new Student{Id = "972a7b99-ae9c-48c6-bb44-b067aad9c9ec", FirstName="Laura",LastName="Norman", Enrollments = new List<Enrollment>()},
                new Student{Id = "8a740ae9-3b8e-4430-ba63-886588161e56", FirstName="Nino",LastName="Olivetto", Enrollments = new List<Enrollment>()}
            };

            Students = new List<Student>();
            students.ForEach(s => Students.Add(s));

            var courses = new List<Course>
            {
                new Course{CourseId="1fa53b20-149e-4916-a2b9-b36fec4444d9",Title="Chemistry",Credits=3,},
                new Course{CourseId="ad938a7d-ead9-4610-8252-d4ef4823f194",Title="Microeconomics",Credits=3,},
                new Course{CourseId="a3277b72-e167-4dad-ac3f-af39d9538c6d",Title="Macroeconomics",Credits=3,},
                new Course{CourseId="04db0499-d58b-4666-8242-a7a654e8ba15",Title="Calculus",Credits=4,},
                new Course{CourseId="24d8b851-d6c7-480f-9200-f139a66ac277",Title="Trigonometry",Credits=4,},
                new Course{CourseId="d4734d5c-053f-41ed-8362-4f71d91f1343",Title="Composition",Credits=3,},
                new Course{CourseId="a2ef2da9-c890-479e-8f9e-322d21edf617",Title="Literature",Credits=4,}
            };

            Courses = new List<Course>();
            courses.ForEach(c => Courses.Add(c));

            var enrollments = new List<Enrollment>
            {
                new Enrollment{EnrollmentId = "e9935f46-7585-4728-93de-26bbb0efe678",Course=Courses[1],Grade=10},
                new Enrollment{EnrollmentId = "7d2c4fb6-6e52-4bf3-824c-1e6a79940bd8",Course=Courses[2],Grade=6},
                new Enrollment{EnrollmentId = "1ac63916-2005-4ef2-a50d-01cde2cae5a1",Course=Courses[3],Grade=8},
                new Enrollment{EnrollmentId = "19fbe2e0-33ba-4886-ad9b-123243a852ac",Course=Courses[4],Grade=8},
                new Enrollment{EnrollmentId = "4da75701-933a-4f2f-adba-af33e2b830cc",Course=Courses[5],Grade=5},
                new Enrollment{EnrollmentId = "9579aeab-d140-49cf-8013-0bfa0b977fc7",Course=Courses[6],Grade=5},
                new Enrollment{EnrollmentId = "e71d7017-3702-4be7-96ff-2daca93d2ec5",Course=Courses[1]},
                new Enrollment{EnrollmentId = "a172da8f-a711-4b31-bd6e-8fb649623e57",Course=Courses[1]},
                new Enrollment{EnrollmentId = "8453aa1d-ae91-4ec1-bb28-64e4469e57fd",Course=Courses[2],Grade=4},
                new Enrollment{EnrollmentId = "5d4ba698-2c64-43ee-b983-bd6f591826a3",Course=Courses[3],Grade=8},
                new Enrollment{EnrollmentId = "828d3f30-3204-466c-a681-7e57d4aa6562",Course=Courses[4]},
                new Enrollment{EnrollmentId = "28210746-e0f5-4244-826f-1cfd09b353ac",Course=Courses[5],Grade=10},
            };

            Students[0].Enrollments.Add(enrollments[0]);
            Students[0].Enrollments.Add(enrollments[1]);
            Students[0].Enrollments.Add(enrollments[2]);
            Students[1].Enrollments.Add(enrollments[3]);
            Students[1].Enrollments.Add(enrollments[4]);
            Students[1].Enrollments.Add(enrollments[5]);
            Students[2].Enrollments.Add(enrollments[6]);
            Students[3].Enrollments.Add(enrollments[7]);
            Students[3].Enrollments.Add(enrollments[8]);
            Students[4].Enrollments.Add(enrollments[9]);
            Students[5].Enrollments.Add(enrollments[10]);
            Students[6].Enrollments.Add(enrollments[11]);

            Enrollments = new List<Enrollment>();
            enrollments.ForEach(e => Enrollments.Add(e));
        }
        public List<Student> Students { get; set; }
        public List<Enrollment> Enrollments { get; set; }
        public List<Course> Courses { get; set; }
    }
}
