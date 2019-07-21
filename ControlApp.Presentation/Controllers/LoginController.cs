using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlApp.ApiCore.Management;
using ControlApp.Entities.Objects;

namespace ControlApp.Presentation.Controllers
{
    public class LoginController : Controller
    {
        UserManagement mUser = new UserManagement();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User Obj)
        {
            
            //return Authentication(usr) ? View("CreateNote") : View();
            //return true ? RedirectToAction("CreateNote", "CreateNote") : RedirectToAction("Login", "Login");
            return RedirectToAction("CreateNote", "CreateNote");
        }
        public bool Authentication(User Obj)
        {
            var list = mUser.RetrieveAllForLogin<User>(Obj);
            return (list.Count > 0) ? true : false;
        }
    }
}