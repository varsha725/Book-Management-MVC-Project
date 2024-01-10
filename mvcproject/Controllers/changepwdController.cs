using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcproject.Models;

namespace mvcproject.Controllers
{
    public class changepwdController : Controller
    {
        mvcprojectEntities dbobj = new mvcprojectEntities();
        // GET: changepwd
        public ActionResult pwd_load()
        {
            return View();
        }

        public ActionResult pwd_click(userpwd objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_pwdchange(Session["uname"].ToString(), objcls.oldpassword,
                objcls.newpassword, op);
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    objcls.msg = "password changed";
                    return View("pwd_load", objcls);
                }
                else
                {
                    objcls.msg = "invalid password";
                    return View("pwd_load", objcls);
                }
            }
            return View("pwd_load", objcls);

        }
    }
}