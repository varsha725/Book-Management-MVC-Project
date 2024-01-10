using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcproject.Models
{
	public class userpwd
	{
		public string oldpassword { set; get; }
		[Required(ErrorMessage = "enter password")]
		public string newpassword { set; get; }
		[Compare("newpassword", ErrorMessage = "password mismatch")]
		public string confirmpassword { set; get; }
		public string msg { set; get; }
	}
}