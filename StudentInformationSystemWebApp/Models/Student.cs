using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentInformationSystemWebApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Select a Date")]
        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Contact { get; set; }

        [Required]
        [EmailAddress] 
        public string Email { get; set; }

        [Required]
        [Display(Name = "Father Name")]
        public string FatherName { get; set; }

        [Required]
        [Display(Name = "Father Ocupasion")]
        public string FatherOcupasion { get; set; }

        [Required]
        [Display(Name = "Father Contact No")]
        public string FatherContact { get; set; }

        [Required]
        [Display(Name = "Mother Name")]
        public string MotherName { get; set; }

        [Required]
        [Display(Name = "Mother Ocupasion")]
        public string MotherOcupasion { get; set; }

        [Required]
        [Display(Name = "Mother Contact No")]
        public string MotherContact { get; set; }

        [Required(ErrorMessage = "Please Select a Date")]
        [Display(Name = "Entry Date")]
        public DateTime EntryDate { get; set; }

        [Required(ErrorMessage = "Please Select a Date")]
        [Display(Name = "Update Date")]
        public DateTime UpdateDate { get; set; }

    }
}
