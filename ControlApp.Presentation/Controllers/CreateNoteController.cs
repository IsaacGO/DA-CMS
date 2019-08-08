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
            Note ObjNote = new Note();
            ObjNote.Note_Date = Convert.ToDateTime(DateTime.Now);
            return View(ObjNote);
        }
        [HttpPost]
        public ActionResult Cancel() { return View("CreateNote"); }

        [HttpPost]
        public ActionResult Submit([Bind(Include = "Id_Note, Note_Title, Note_Content, Note_Date, State")] Note pNote)
        {
            Note ObjNote = new Note();
            ObjNote = pNote;
            ObjNote.Note_Date = Convert.ToDateTime(DateTime.Now);
            ObjNote.CreateBy = (string)Session["username"];
            mNote.Create(ObjNote);
            //ViewBag.Msg = "Created Note";
            return View("CreateNote");
        }

        [HttpPost]
        public ActionResult Modify([Bind(Include = "Id_Note, Note_Title, Note_Content, Note_Date, State")] Note pNote)
        {
            Note ObjNote = new Note();
            ObjNote = pNote;
            ObjNote.UpdateBy = (string)Session["username"];
            mNote.Update(ObjNote);
            //ViewBag.Msg = "Modified Note";
            return RedirectToAction("ShowView", ObjNote);
        }

        [HttpPost]
        public ActionResult Consult([Bind(Include = "Id_Note, Note_Title, Note_Content, Note_Date, State")] Note pNote)
        {
            Note n = new Note { ID_Note = Convert.ToInt32(pNote.ID_Note) };
            var lst = mNote.RetrieveAllById<Note>(n);
            return RedirectToAction("ShowView", lst[0]);
        }

        public ActionResult ShowView(Note Obj) { return View("CreateNote", Obj); }

    }
}