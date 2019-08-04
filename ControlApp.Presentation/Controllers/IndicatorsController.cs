using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlApp.Presentation.Controllers
{
    public class IndicatorsController : Controller
    {
        // GET: Indicators
        public ActionResult Indicators()
        {
            ViewBag.username = Session["username"];
            return View();
        }
    }
}