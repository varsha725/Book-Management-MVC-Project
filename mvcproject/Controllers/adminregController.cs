using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcproject.Models;

namespace mvcproject.Controllers
{
    public class adminregController : Controller
    {
        mvcprojectEntities dbobj = new mvcprojectEntities();
        // GET: adminreg
        public ActionResult register_pageload()
        {
            return View();
        }

        public ActionResult register_click(adminregister objcls)
        {
            if(ModelState.IsValid)
			{
                dbobj.sp_regadmin(objcls.name, objcls.address, objcls.email, objcls.username, objcls.password);
                objcls.msg = "Successfully Registerd";
                return View("register_pageload", objcls);
			}
            return View("register_pageload",objcls);






        }
    }
}