using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlApp.Presentation.Controllers
{
    public class UploadNoteDiagramController : Controller
    {
        // GET: UploadNoteDiagram
        public ActionResult UploadNoteDiagram()
        {
            ViewBag.username = Session["username"];
            return View(); return View();
        }
    }
}