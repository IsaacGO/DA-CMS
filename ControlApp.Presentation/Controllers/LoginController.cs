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
        public ActionResult Login() { return View(new User { ID_User = "0" }); }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            if (Authentication(Username, Password))
                return RedirectToAction("Index");
            else
                return View(new User { ID_User = "-1" } );
        }

        public bool Authentication(string Username, string Password)
        {
            var list = mUser.RetrieveAllUser<User>();

            if (list.Count > 0)
            {
                foreach (var obj in list)
                {
                    if (obj.User_nickname.Equals(Username) && obj.User_pass.Equals(Password))
                    {
                        Session["username"] = Username;
                        Session["idUser"] = obj.ID_User;
       
                        return true;
                    }
                }
            }
            return false;
        }
        public ActionResult Index()
        {
            ViewBag.username = Session["username"];
            return View();
        }

        
    }

}