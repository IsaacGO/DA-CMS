using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlApp.Presentation.Controllers
{
    public class WeeklyReportController : Controller
    {
        // GET: WeeklyReport
        public ActionResult WeeklyReport()
        {
            ViewBag.username = Session["username"];
            return View();
        }
    }
}