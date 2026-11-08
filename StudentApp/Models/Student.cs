using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace StudentApp.Models
{
    public class Student
    {
        public int Id { get;set; }

        [Required(ErrorMessage = "Full name is required.")]
        [StringLength(50, MinimumLength = 2, 
        ErrorMessage = "Name must be between 2 and 50 characters.")]
        [Display(Name = "Full Name")]
        public string FullName{get; set;} = string.Empty;

        [Required(ErrorMessage = "Course is required.")]
        [StringLength(100, MinimumLength = 2, 
        ErrorMessage = "Course must be between 2 and 100 characters.")]
        [Display(Name = "Course")]
        public string Course{get; set;} = string.Empty;
        
        [Range(1,5, ErrorMessage = "Year Level must be between 1 and 5.")]
        [Display(Name = "Year Level")]
        public int YearLevel{get; set;}
    }
}