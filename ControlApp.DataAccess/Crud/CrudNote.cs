using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq; // Manipulacion de bases de datos SQL
using System.Data.Linq.Mapping; // otra clase por importar para la Manipulacion
using ControlApp.Entities.Objects;


namespace ControlApp.DataAccess.Crud
{
    public class CrudNote : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();

        public override bool Activate(BaseEntity entity)
        {

            var ObjNote = (Note)entity;
            Context.SP_CRUD_NOTE((int)CrudActionEnum.Activate, ObjNote.UpdateBy, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date
            , ObjNote.Note_Content);
            return true;
        }
        public override bool Create(BaseEntity entity)
        {
            var ObjNote = (Note)entity;
            Context.SP_CRUD_NOTE((int)CrudActionEnum.Create, ObjNote.CreateBy, ObjNote.ID_Note, ObjNote.Note_Title,ObjNote.Note_Date
                ,ObjNote.Note_Content);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {

            var ObjNote = (Note)entity;
            Context.SP_CRUD_NOTE((int)CrudActionEnum.Delete, ObjNote.UpdateBy, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date   
            , ObjNote.Note_Content);
            return true;
        }
        public override List<T> SuperRetrieve<T>()
        {
            var ObjNote = new Note();
            var lst = new List<T>();
            List<Note> MyList = new List<Note>();
            var Query = Context.SP_CRUD_NOTE((int)CrudActionEnum.SuperRetrieve, ObjNote.IdSession, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date
                , ObjNote.Note_Content).ToList();
            foreach (SP_CRUD_NOTEResult Element in Query)
            {
                Note Obj = new Note(Element.ID_NOTE,Element.NOTE_TITLE,Element.NOTE_DATE,Element.NOTE_CONTENT,Element.NOTE_STATE,
                    Element.NOTE_CREATEBY, Element.NOTE_CREATEDATE,Element.NOTE_UPDATEBY,Element.NOTE_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> SuperRetrieveById<T>(BaseEntity entity)
        {
            var ObjNote = new Note();
            var lst = new List<T>();
            List<Note> MyList = new List<Note>();
            var Query = Context.SP_CRUD_NOTE((int)CrudActionEnum.SuperRetrieve, ObjNote.IdSession, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date
                , ObjNote.Note_Content).ToList();
            foreach (SP_CRUD_NOTEResult Element in Query)
            {
                Note Obj = new Note(Element.ID_NOTE, Element.NOTE_TITLE, Element.NOTE_DATE, Element.NOTE_CONTENT, Element.NOTE_STATE,
                    Element.NOTE_CREATEBY, Element.NOTE_CREATEDATE, Element.NOTE_UPDATEBY, Element.NOTE_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> SuperRetrieveByName<T>(BaseEntity entity)
        {
            var ObjNote = new Note();
            var lst = new List<T>();
            List<Note> MyList = new List<Note>();
            var Query = Context.SP_CRUD_NOTE((int)CrudActionEnum.SuperRetrieve, ObjNote.IdSession, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date
                , ObjNote.Note_Content).ToList();
            foreach (SP_CRUD_NOTEResult Element in Query)
            {
                Note Obj = new Note(Element.ID_NOTE, Element.NOTE_TITLE, Element.NOTE_DATE, Element.NOTE_CONTENT, Element.NOTE_STATE,
                    Element.NOTE_CREATEBY, Element.NOTE_CREATEDATE, Element.NOTE_UPDATEBY, Element.NOTE_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> RetrieveAll<T>()
        {
            var ObjNote = new Note();
            var lst = new List<T>();
            List<Note> MyList = new List<Note>();
            var Query = Context.SP_CRUD_NOTE((int)CrudActionEnum.RetrieveAll, ObjNote.IdSession, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date
                , ObjNote.Note_Content).ToList();
            foreach (SP_CRUD_NOTEResult Element in Query)
            {
                Note Obj = new Note(Element.ID_NOTE, Element.NOTE_TITLE, Element.NOTE_DATE, Element.NOTE_CONTENT);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> RetrieveById<T>(BaseEntity entity)
        {
            var ObjNote = new Note();
            var lst = new List<T>();
            List<Note> MyList = new List<Note>();
            var Query = Context.SP_CRUD_NOTE((int)CrudActionEnum.RetrieveAll, ObjNote.IdSession, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date
                , ObjNote.Note_Content).ToList();
            foreach (SP_CRUD_NOTEResult Element in Query)
            {
                Note Obj = new Note(Element.ID_NOTE, Element.NOTE_TITLE, Element.NOTE_DATE, Element.NOTE_CONTENT);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> RetrieveByName<T>(BaseEntity entity)
        {
            var ObjNote = new Note();
            var lst = new List<T>();
            List<Note> MyList = new List<Note>();
            var Query = Context.SP_CRUD_NOTE((int)CrudActionEnum.RetrieveAll, ObjNote.IdSession, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date
                , ObjNote.Note_Content).ToList();
            foreach (SP_CRUD_NOTEResult Element in Query)
            {
                Note Obj = new Note(Element.ID_NOTE, Element.NOTE_TITLE, Element.NOTE_DATE, Element.NOTE_CONTENT);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override bool Update(BaseEntity entity)
        {

            var ObjNote = (Note)entity;
            Context.SP_CRUD_NOTE((int)CrudActionEnum.Update, ObjNote.UpdateBy, ObjNote.ID_Note, ObjNote.Note_Title, ObjNote.Note_Date
                , ObjNote.Note_Content);
            return true;
        }
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
