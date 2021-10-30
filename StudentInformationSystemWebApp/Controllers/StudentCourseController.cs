using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentInformationSystemWebApp.Models;

namespace StudentInformationSystemWebApp.Controllers
{
    public class StudentCourseController : Controller
    {
        private ApplicationDbContext _context;

        public StudentCourseController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //
        // GET: /StudentCourse/
        [HttpGet]
        public ActionResult Save()
        {
            var studentList = _context.Students.ToList();
            var courseList = _context.Courses.ToList();
            var semesterList = new List<Semester>
            {
                new Semester() {Name = "Spring", Code = "SP"},
                new Semester() {Name = "Summer", Code = "SU"},
                new Semester() {Name = "Fall", Code = "FA"}
            };
            var viewModel = new StudentCourseViewModel()
            {
                StudentList = studentList,
                CourseList = courseList,
                SemesterList = semesterList
            };

            return View(viewModel);
        }
	}
}