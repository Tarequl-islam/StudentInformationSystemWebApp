using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentInformationSystemWebApp.Models;

namespace StudentInformationSystemWebApp.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _context;

        public StudentController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //
        // GET: /Student/
        [HttpGet]
        public ActionResult Save()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
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