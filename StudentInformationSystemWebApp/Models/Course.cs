using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInformationSystemWebApp.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public double Credit { get; set; }

        [Required]
        [Display(Name = "Contact Hour")]
        public double ContactHour { get; set; }


    }
}