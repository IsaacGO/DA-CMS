using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlApp.Presentation.Controllers
{
    public class CreateDepartmentController : Controller
    {
        // GET: CreateDepartment
        public ActionResult CreateDepartment()
        {
            ViewBag.username = Session["username"];
            return View();
        }
    }
}