using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;

namespace ControlApp.DataAccess.Crud
{
    public class CrudPosition : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Activate(BaseEntity entity)
        {
            var ObjPst = (Position)entity;
            Context.SP_CRUD_POSITION((int)CrudActionEnum.Activate, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.UpdateBy, ObjPst.Name_Position);
            return true;
        }
        public override bool Create(BaseEntity entity)
        {
            var ObjPst = (Position)entity;
            Context.SP_CRUD_POSITION((int)CrudActionEnum.Create, ObjPst.ID_Position, ObjPst.ID_Area ,ObjPst.CreateBy, ObjPst.Name_Position);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjPst = (Position)entity;
            Context.SP_CRUD_POSITION((int)CrudActionEnum.Delete, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.UpdateBy, ObjPst.Name_Position);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var ObjPst = new Position();
            var lst = new List<T>();
            List<Position> MyList = new List<Position>();
            var Query = Context.SP_CRUD_POSITION((int)CrudActionEnum.RetrieveAll, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.IdSession, ObjPst.Name_Position).ToList();
            foreach (SP_CRUD_POSITIONResult Element in Query)
            {
                Position Obj = new Position(Element.ID_POSITION, Element.AREA_NAME, Element.NAME_POSITION);
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
            var ObjPst = (Position)entity;
            var lst = new List<T>();
            List<Position> MyList = new List<Position>();
            var Query = Context.SP_CRUD_POSITION((int)CrudActionEnum.RetrieveById, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.IdSession, ObjPst.Name_Position).ToList();
            foreach (SP_CRUD_POSITIONResult Element in Query)
            {
                Position Obj = new Position(Element.ID_POSITION, Element.AREA_NAME, Element.NAME_POSITION);
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
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public override List<T> RetrieveByName<T>(BaseEntity entity)
        {
            var ObjPst = (Position)entity;
            var lst = new List<T>();
            List<Position> MyList = new List<Position>();
            var Query = Context.SP_CRUD_POSITION((int)CrudActionEnum.RetrieveByName, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.IdSession, ObjPst.Name_Position).ToList();
            foreach (SP_CRUD_POSITIONResult Element in Query)
            {
                Position Obj = new Position(Element.ID_POSITION, Element.AREA_NAME, Element.NAME_POSITION);
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
        public override List<T> SuperRetrieve<T>()
        {
            var ObjPst = new Position();
            var lst = new List<T>();
            List<Position> MyList = new List<Position>();
            var Query = Context.SP_CRUD_POSITION((int)CrudActionEnum.SuperRetrieve, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.IdSession, ObjPst.Name_Position).ToList();
            foreach (SP_CRUD_POSITIONResult Element in Query)
            {
                Position Obj = new Position(Element.ID_POSITION, Element.AREA_NAME,Element.NAME_POSITION, Element.POSITION_STATE, Element.CREATEBY_PST, Element.UPDATEBY_PST, 
                    Element.POSITION_CREATEDATE, Element.POSITION_UPDATEDATE);
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
            var ObjPst = (Position)entity;
            var lst = new List<T>();
            List<Position> MyList = new List<Position>();
            var Query = Context.SP_CRUD_POSITION((int)CrudActionEnum.SuperRetrieveById, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.IdSession, ObjPst.Name_Position).ToList();
            foreach (SP_CRUD_POSITIONResult Element in Query)
            {
                Position Obj = new Position(Element.ID_POSITION, Element.AREA_NAME, Element.NAME_POSITION, Element.POSITION_STATE, Element.CREATEBY_PST, Element.UPDATEBY_PST,
                    Element.POSITION_CREATEDATE, Element.POSITION_UPDATEDATE);
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
            var ObjPst = (Position)entity;
            var lst = new List<T>();
            List<Position> MyList = new List<Position>();
            var Query = Context.SP_CRUD_POSITION((int)CrudActionEnum.SuperRetrieveByName, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.IdSession, ObjPst.Name_Position).ToList();
            foreach (SP_CRUD_POSITIONResult Element in Query)
            {
                Position Obj = new Position(Element.ID_POSITION, Element.AREA_NAME, Element.NAME_POSITION, Element.POSITION_STATE, Element.CREATEBY_PST, Element.UPDATEBY_PST,
                    Element.POSITION_CREATEDATE, Element.POSITION_UPDATEDATE);
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
            var ObjPst = (Position)entity;
            Context.SP_CRUD_POSITION((int)CrudActionEnum.Update, ObjPst.ID_Position, ObjPst.ID_Area, ObjPst.IdSession, ObjPst.Name_Position);
            return true;
        }
    }
}
