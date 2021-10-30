using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInformationSystemWebApp.Models
{
    public class StudentCourse
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Select a Student")]
        [Display(Name = "Course")]
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        [Required(ErrorMessage = "Please Select a Semester")]
        [Display(Name = "Semester")]
        public string SemesterCode { get; set; }

        public DateTime? EntryDate { get; set; }

        public StudentCourse()
        {
            EntryDate = DateTime.Today;
        }

    }
}