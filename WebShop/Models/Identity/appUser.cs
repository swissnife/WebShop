using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models.Identity
{
    public class AppUser:IdentityUser
    {
        [Required(ErrorMessage = "Full Mane is Required!")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
    }
}