using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcproject.Models;

namespace mvcproject.Controllers
{
    public class dbloginController : Controller
    {
        mvcprojectEntities dbobj = new mvcprojectEntities();
        // GET: dblogin
        public ActionResult login_pageload()
        {
            return View();
        }

        public ActionResult home(bookk ob)
        {
            return View(dbobj.bookks.ToList());
        }

        public ActionResult login_click(login objcls)
        {
            if(ModelState.IsValid)
			{
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_login(objcls.username, objcls.password, op);
                int val = Convert.ToInt32(op.Value);
                if(val==1)
				{
                    Session["uname"] = objcls.username;
                    return RedirectToAction("home");
				}
				else
				{
                    ModelState.Clear();
                    objcls.msg = "Invalid Login";
                    return View("login_pageload", objcls);
				}
			}




            return View("login_pageload",objcls);
        }


    }
}