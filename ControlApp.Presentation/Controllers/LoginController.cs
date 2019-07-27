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

        // GET: Prueba
        public ActionResult Login() { return View(); }

        public ActionResult Authentication(string Username, string Password)
        {

            var list = mUser.RetrieveAllUser<User>();

            if (list.Count > 0)
            {
                foreach (var obj in list)
                {
                    if (obj.User_nickname.Equals(Username) && obj.User_pass.Equals(Password)) { return RedirectToAction("Index"); }
                }
            }
            return RedirectToAction("Login");
        }
        public ActionResult Index() { return View(); }
    }
}