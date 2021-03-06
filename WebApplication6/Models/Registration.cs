//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    
    public partial class Registration
    {   [Key]
        public int UserID { get; set; }
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "Enter your First Name")]


        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Enter your Last Name")]


        public string lastName { get; set; }
        [Display(Name = "EmailID")]
        [Required(ErrorMessage = "Enter your email Name")]
        [DataType(DataType.EmailAddress)]

        public string EmailID { get; set; }
        [Display(Name = "Date")]
        [Required(ErrorMessage = "Enter your Date")]
        [DataType(DataType.Date)]
        public System.DateTime DateOfBirth { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter your password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "at least 6 digits")]
        public string password { get; set; }
        public bool IsEmailValid { get; set; }
        public System.Guid ActivtionCode { get; set; }
        [Display(Name = "confirmPassword")]
        [Required(ErrorMessage = "Enter your email Name")]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string cofirmPassword { get; set; }
        [Display(Name = "img")]
        
        [DataType(DataType.ImageUrl)]
        public string img { get; set; }

        public virtual Login Login { get; set; }
    }
}
