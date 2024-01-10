using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcproject.Models
{
	public class adminregister
	{

        [Required(ErrorMessage = "Enter Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Enter Address")]
        public string address { get; set; }

        [EmailAddress(ErrorMessage = "Enter Email Address")]
        public string email { get; set; }

        [Required(ErrorMessage = "Enter Username")]
        public string username { get; set; }

        [Required(ErrorMessage = "Enter Password")]

        public string password { get; set; }

        [Compare("password",ErrorMessage ="password mismatch")]
        public string confirmpassword { get; set; }

        public string msg { get; set; }




    }
}