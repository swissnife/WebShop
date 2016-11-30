using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models.Identity
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Full Mane is Required!")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is Required!")]
        [Display(Name = "EMail")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "User Name is Required!")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required!")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Password is betwen 8 & 20 char!")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm Password is not match!")]
        public string ConfirmPassword { get; set; }
    }
}