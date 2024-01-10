using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcproject.Models;

namespace mvcproject.Controllers
{
    public class addbookController : Controller
    {
        mvcprojectEntities dbobj = new mvcprojectEntities();
        // GET: addbook
        public ActionResult book_load()
        {
            return View();
        }

        public ActionResult book_click(bookinsert objcls, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/phs");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);
                    var fullpath = Path.Combine("~\\phs", fname);
                    objcls.image = fullpath;
                }
                dbobj.sp_bookkadd(objcls.bookname, objcls.author, objcls.image, objcls.price);
                objcls.msg = "book added";
                return View("book_load", objcls);
            }
            return View("book_load", objcls);
        }





    }
}