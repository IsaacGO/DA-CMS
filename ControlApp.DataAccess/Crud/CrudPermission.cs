using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;


namespace ControlApp.DataAccess.Crud
{
    public class CrudPermission : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Activate(BaseEntity entity)
        {
            var ObjPer = (Permission)entity;
            Context.SP_CRUD_PER((int)CrudActionEnum.Activate, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per);
            return true;
        }
        public override bool Create(BaseEntity entity)
        {
            var ObjPer = (Permission)entity;
            Context.SP_CRUD_PER((int)CrudActionEnum.Create, ObjPer.CreateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjPer = (Permission)entity;
            Context.SP_CRUD_PER((int)CrudActionEnum.Delete, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var ObjPer = new Permission();
            var lst = new List<T>();
            List<Permission> MyList = new List<Permission>();
            var Query = Context.SP_CRUD_PER((int)CrudActionEnum.RetrieveAll, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per).ToList();
            foreach (SP_CRUD_PERResult Element in Query)
            {
                Permission Obj = new Permission(Element.ID_PER, Element.NAME_DPT, Element.NAME_PERMISSION, Element.DESCRIP_PERMISSION);
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
            var ObjPer = (Permission)entity;
            var lst = new List<T>();
            List<Permission> MyList = new List<Permission>();
            var Query = Context.SP_CRUD_PER((int)CrudActionEnum.RetrieveAll, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per).ToList();
            foreach (SP_CRUD_PERResult Element in Query)
            {
                Permission Obj = new Permission(Element.ID_PER, Element.NAME_DPT, Element.NAME_PERMISSION, Element.DESCRIP_PERMISSION);
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
            var ObjPer = (Permission)entity;
            var lst = new List<T>();
            List<Permission> MyList = new List<Permission>();
            var Query = Context.SP_CRUD_PER((int)CrudActionEnum.RetrieveAll, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per).ToList();
            foreach (SP_CRUD_PERResult Element in Query)
            {
                Permission Obj = new Permission(Element.ID_PER, Element.NAME_DPT, Element.NAME_PERMISSION, Element.DESCRIP_PERMISSION);
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
            var ObjPer = new Permission();
            var lst = new List<T>();
            List<Permission> MyList = new List<Permission>();
            var Query = Context.SP_CRUD_PER((int)CrudActionEnum.SuperRetrieve, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per).ToList();
            foreach (SP_CRUD_PERResult Element in Query)
            {
                Permission Obj = new Permission(Element.ID_PER, Element.NAME_DPT, Element.NAME_PERMISSION, Element.DESCRIP_PERMISSION, Element.PER_STATE, Element.PER_CREATEBY,
                    Element.PER_UPDATEDBY, Element.PER_CREATEDATE, Element.PER_UPDATEDATE);
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
            var ObjPer = (Permission)entity;
            var lst = new List<T>();
            List<Permission> MyList = new List<Permission>();
            var Query = Context.SP_CRUD_PER((int)CrudActionEnum.SuperRetrieveById, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per).ToList();
            foreach (SP_CRUD_PERResult Element in Query)
            {
                Permission Obj = new Permission(Element.ID_PER, Element.NAME_DPT, Element.NAME_PERMISSION, Element.DESCRIP_PERMISSION, Element.PER_STATE, Element.PER_CREATEBY,
                    Element.PER_UPDATEDBY, Element.PER_CREATEDATE, Element.PER_UPDATEDATE);
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
            var ObjPer = (Permission)entity;
            var lst = new List<T>();
            List<Permission> MyList = new List<Permission>();
            var Query = Context.SP_CRUD_PER((int)CrudActionEnum.SuperRetrieveByName, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per).ToList();
            foreach (SP_CRUD_PERResult Element in Query)
            {
                Permission Obj = new Permission(Element.ID_PER, Element.NAME_DPT, Element.NAME_PERMISSION, Element.DESCRIP_PERMISSION, Element.PER_STATE, Element.PER_CREATEBY,
                    Element.PER_UPDATEDBY, Element.PER_CREATEDATE, Element.PER_UPDATEDATE);
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
            var ObjPer = (Permission)entity;
            Context.SP_CRUD_PER((int)CrudActionEnum.Delete, ObjPer.UpdateBy, ObjPer.ID_Per, ObjPer.ID_Dpt, ObjPer.Name_Per, ObjPer.Descrip_Per);
            return true;
        }
    }
}
