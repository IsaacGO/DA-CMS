using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlApp.Presentation.Controllers
{
    public class CreatePermissionController : Controller
    {
        // GET: CreatePermission
        public ActionResult CreatePermission()
        {
            ViewBag.username = Session["username"];
            return View();
        }
    }
}