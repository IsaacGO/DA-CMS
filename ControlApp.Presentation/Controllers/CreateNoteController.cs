using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControlApp.ApiCore.Management;
using ControlApp.Entities.Objects;

namespace ControlApp.Presentation.Controllers
{
    public class CreateNoteController : Controller
    {
        NoteManagement mNote = new NoteManagement();
        // GET: CreateNote
        public ActionResult CreateNote()
        {
            ViewBag.username = Session["username"];
            return View();
        }
        [HttpPost]
        public ActionResult Cancel() { return View("CreateNote"); }

        [HttpPost]
        public ActionResult Submit(string pNote_Title, DateTime pNote_Date, string pNote_Content)
        {
            Note ObjNote = new Note();
            ObjNote.CreateBy = (string)Session["username"];
            ObjNote.Note_Title = pNote_Title;
            ObjNote.Note_Date = pNote_Date;
            ObjNote.Note_Content = pNote_Content;
            mNote.Create(ObjNote);
            ViewBag.Msg = "Note created!!!";
            return View("CreateNote");
        }

        [HttpPost]
        public ActionResult Modify()
        {
            ViewBag.Msg = "Funciona Submit!!!";
            return View("CreateNote");
        }

        [HttpPost]
        public ActionResult Consult()
        {
            ViewBag.Msg = "Isaac";
            return View("CreateNote");
        }


        //[HttpPost]
        //public ActionResult CreateNote(string cancel, string submit)
        //{
        //    if (cancel != null)
        //        return RedirectToAction("Login");
        //    if (submit != null)
        //        return RedirectToAction("CreateNote");


        //    return null;
        //}

    }
}