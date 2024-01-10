using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcproject.Models
{
	public class bookinsert
	{
		[Required(ErrorMessage = "Enter Bookname")]
		public string bookname { get; set; }

		[Required(ErrorMessage = "Enter Author")]

		public string author { get; set; }


		public string image { get; set; }

		[Required(ErrorMessage = "Enter Price")]

		public int price { get; set; }

		public string msg { get; set; }

	}
}