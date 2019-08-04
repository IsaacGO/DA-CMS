using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlApp.Presentation.Controllers
{
    public class CreateRoleController : Controller
    {
        // GET: CreateRole
        public ActionResult CreateRole()
        {
            ViewBag.username = Session["username"];
            return View();
        }
    }
}