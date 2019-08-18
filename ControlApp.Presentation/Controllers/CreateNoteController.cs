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
            return View(mNote.RetrieveAll<Note>());
        }
        
        public ActionResult EditNote(int? id)
        {
            ViewBag.username = Session["username"];
            if (id == -1) { return View(); }
            else
            {
                Note n = new Note { ID_Note = Convert.ToInt32(id) };
                var lst = mNote.RetrieveAllById<Note>(n);
                return View(lst[0]);
            }
        }

        [HttpPost]
        public ActionResult EditNote([Bind(Include = "ID_Note,Note_Title,Note_Date,Note_Content,State")] Note n)
        {
            Note ObjNote = n;
            if (n.ID_Note == 0)
            {
                ObjNote.CreateBy = (string)Session["username"];
                mNote.Create(ObjNote);
            }
            else
            {
                ObjNote.UpdateBy = (string)Session["username"];
                mNote.Update(ObjNote);
                if (n.State != null)
                {
                    if (n.State == true)
                        mNote.Activate(ObjNote);
                    else
                        mNote.Delete(ObjNote);
                }
            }
            return RedirectToAction("CreateNote");
        }
    }
}