using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformationSystemWebApp.Models
{
    public class StudentCourseViewModel
    {
        public IEnumerable<Student> StudentList { get; set; }
        public IEnumerable<Course> CourseList { get; set; }
        public IEnumerable<Semester> SemesterList { get; set; }
        public StudentCourse StudentCourse { get; set; }

    }
}