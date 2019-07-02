using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;

namespace ControlApp.DataAccess.Crud
{
    public class CrudDepartament : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Create(BaseEntity entity)
        {
            var ObjDpt = (Departament)entity;
            Context.SP_CRUD_DPT((int)CrudActionEnum.Create, ObjDpt.ID_Dpt, ObjDpt.CreateBy, ObjDpt.Name_Dpt);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjDpt = (Departament)entity;
            Context.SP_CRUD_DPT((int)CrudActionEnum.Delete, ObjDpt.ID_Dpt, ObjDpt.UpdateBy, ObjDpt.Name_Dpt);
            return true;
        }
        public override List<T> SuperRetrieve<T>()
        {
            var ObjDpt = new Departament();
            var lst = new List<T>();
            List<Departament> MyList = new List<Departament>();
            var Query = Context.SP_CRUD_DPT((int)CrudActionEnum.SuperRetrieve, ObjDpt.ID_Dpt, ObjDpt.IdSession, ObjDpt.Name_Dpt).ToList();
            foreach (SP_CRUD_DPTResult Element in Query)
            {
                Departament Obj = new Departament(Element.ID_DPT, Element.NAME_DPT, Element.STATE_DPT, Element.CREATEBY_DPT, Element.UPDATEBY_DPT,
                    Element.CREATEDATE_DPT, Element.UPDATEDATE_DPT);
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
            var ObjDpt = (Departament)entity;
            var lst = new List<T>();
            List<Departament> MyList = new List<Departament>();
            var Query = Context.SP_CRUD_DPT((int)CrudActionEnum.SuperRetrieveById, ObjDpt.ID_Dpt, ObjDpt.IdSession, ObjDpt.Name_Dpt).ToList();
            foreach (SP_CRUD_DPTResult Element in Query)
            {
                Departament Obj = new Departament(Element.ID_DPT, Element.NAME_DPT, Element.STATE_DPT, Element.CREATEBY_DPT, Element.UPDATEBY_DPT,
                    Element.CREATEDATE_DPT, Element.UPDATEDATE_DPT);
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
            var ObjDpt = (Departament)entity;
            var lst = new List<T>();
            List<Departament> MyList = new List<Departament>();
            var Query = Context.SP_CRUD_DPT((int)CrudActionEnum.SuperRetrieveByName, ObjDpt.ID_Dpt, ObjDpt.IdSession, ObjDpt.Name_Dpt).ToList();
            foreach (SP_CRUD_DPTResult Element in Query)
            {
                Departament Obj = new Departament(Element.ID_DPT, Element.NAME_DPT, Element.STATE_DPT, Element.CREATEBY_DPT, Element.UPDATEBY_DPT, 
                    Element.CREATEDATE_DPT,Element.UPDATEDATE_DPT);
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
            var ObjDpt = new Departament();
            var lst = new List<T>();
            List<Departament> MyList = new List<Departament>();
            var Query = Context.SP_CRUD_DPT((int)CrudActionEnum.RetrieveAll, ObjDpt.ID_Dpt, ObjDpt.IdSession, ObjDpt.Name_Dpt).ToList();
            foreach (SP_CRUD_DPTResult Element in Query)
            {
                Departament Obj = new Departament(Element.ID_DPT, Element.NAME_DPT);
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
            var ObjDpt = (Departament)entity;
            var lst = new List<T>();
            List<Departament> MyList = new List<Departament>();
            var Query = Context.SP_CRUD_DPT((int)CrudActionEnum.RetrieveById, ObjDpt.ID_Dpt, ObjDpt.IdSession, ObjDpt.Name_Dpt).ToList();
            foreach (SP_CRUD_DPTResult Element in Query)
            {
                Departament Obj = new Departament(Element.ID_DPT, Element.NAME_DPT);
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
            var ObjDpt = (Departament)entity;
            var lst = new List<T>();
            List<Departament> MyList = new List<Departament>();
            var Query = Context.SP_CRUD_DPT((int)CrudActionEnum.RetrieveByName, ObjDpt.ID_Dpt, ObjDpt.IdSession, ObjDpt.Name_Dpt).ToList();
            foreach (SP_CRUD_DPTResult Element in Query)
            {
                Departament Obj = new Departament(Element.ID_DPT, Element.NAME_DPT);
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
            var ObjDpt = (Departament)entity;
            Context.SP_CRUD_DPT((int)CrudActionEnum.Update, ObjDpt.ID_Dpt, ObjDpt.UpdateBy, ObjDpt.Name_Dpt);
            return true;
        }
        public override bool Activate(BaseEntity entity)
        {
            var ObjDpt = (Departament)entity;
            Context.SP_CRUD_DPT((int)CrudActionEnum.Activate, ObjDpt.ID_Dpt, ObjDpt.IdSession, ObjDpt.Name_Dpt);
            return true;
        }
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
