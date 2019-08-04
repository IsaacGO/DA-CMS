using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControlApp.Presentation.Controllers
{
    public class UploadNoteStyleCorrectionController : Controller
    {
        // GET: UploadNoteStyleCorrection
        public ActionResult UploadNoteStyleCorrection()
        {
            ViewBag.username = Session["username"];
            return View();
        }
    }
}