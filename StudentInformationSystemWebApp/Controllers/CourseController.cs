using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentInformationSystemWebApp.Models;

namespace StudentInformationSystemWebApp.Controllers
{
    public class CourseController : Controller
    {
        private ApplicationDbContext _context;

        public CourseController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //
        // GET: /Course/
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                int rowEffect = _context.SaveChanges();
                if (rowEffect > 0)
                {
                    ViewBag.Messege = "Save Successful";
                    ModelState.Clear();
                }
                else ViewBag.Messege = "Save Failed!";
            }
            else
            {
                ViewBag.Messege = "Model State Invalid";
            }
            return View();
        }
	}
}