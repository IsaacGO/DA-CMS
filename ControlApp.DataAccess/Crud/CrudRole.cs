using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;

namespace ControlApp.DataAccess.Crud
{
    public class CrudRole : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Activate(BaseEntity entity)
        {
            var ObjRole = (Role)entity;
            Context.SP_CRUD_ROLE((int)CrudActionEnum.Activate, ObjRole.UpdateBy, ObjRole.ID_role, ObjRole.Name_role, ObjRole.Descrip_role);
            return true;
        }
        public override bool Create(BaseEntity entity)
        {
            var ObjRole = (Role)entity;
            Context.SP_CRUD_ROLE((int)CrudActionEnum.Create, ObjRole.CreateBy, ObjRole.ID_role, ObjRole.Name_role, ObjRole.Descrip_role);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjRole = (Role)entity;
            Context.SP_CRUD_ROLE((int)CrudActionEnum.Delete, ObjRole.UpdateBy, ObjRole.ID_role, ObjRole.Name_role, ObjRole.Descrip_role);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var ObjRole = new Role();
            var lst = new List<T>();
            List<Role> MyList = new List<Role>();
            var Query = Context.SP_CRUD_ROLE((int)CrudActionEnum.RetrieveAll, ObjRole.IdSession, ObjRole.ID_role,
                ObjRole.Name_role, ObjRole.Descrip_role).ToList();
            foreach (SP_CRUD_ROLEResult Element in Query)
            {
                Role Obj = new Role(Element.ID_ROLE, Element.NAME_ROLE, Element.DESCRIP_ROLE);
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
            var ObjRole = (Role)entity;
            var lst = new List<T>();
            List<Role> MyList = new List<Role>();
            var Query = Context.SP_CRUD_ROLE((int)CrudActionEnum.RetrieveById, ObjRole.IdSession, ObjRole.ID_role,
                ObjRole.Name_role, ObjRole.Descrip_role).ToList();
            foreach (SP_CRUD_ROLEResult Element in Query)
            {
                Role Obj = new Role(Element.ID_ROLE, Element.NAME_ROLE, Element.DESCRIP_ROLE);
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
            var ObjRole = (Role)entity;
            var lst = new List<T>();
            List<Role> MyList = new List<Role>();
            var Query = Context.SP_CRUD_ROLE((int)CrudActionEnum.RetrieveByName, ObjRole.IdSession, ObjRole.ID_role,
                ObjRole.Name_role, ObjRole.Descrip_role).ToList();
            foreach (SP_CRUD_ROLEResult Element in Query)
            {
                Role Obj = new Role(Element.ID_ROLE, Element.NAME_ROLE, Element.DESCRIP_ROLE);
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
            var ObjRole = new Role();
            var lst = new List<T>();
            List<Role> MyList = new List<Role>();
            var Query = Context.SP_CRUD_ROLE((int)CrudActionEnum.SuperRetrieve, ObjRole.IdSession, ObjRole.ID_role, 
                ObjRole.Name_role, ObjRole.Descrip_role).ToList();
            foreach (SP_CRUD_ROLEResult Element in Query)
            {
                Role Obj = new Role(Element.ID_ROLE, Element.NAME_ROLE, Element.DESCRIP_ROLE, Element.ROLE_STATE, Element.ROLE_CREATEBY,
                    Element.ROLE_UPDATEDBY, Element.ROLE_CREATEDATE, Element.ROLE_UPDATEDATE);
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
            var ObjRole = (Role)entity;
            var lst = new List<T>();
            List<Role> MyList = new List<Role>();
            var Query = Context.SP_CRUD_ROLE((int)CrudActionEnum.SuperRetrieveById, ObjRole.IdSession, ObjRole.ID_role,
                ObjRole.Name_role, ObjRole.Descrip_role).ToList();
            foreach (SP_CRUD_ROLEResult Element in Query)
            {
                Role Obj = new Role(Element.ID_ROLE, Element.NAME_ROLE, Element.DESCRIP_ROLE, Element.ROLE_STATE, Element.ROLE_CREATEBY,
                    Element.ROLE_UPDATEDBY, Element.ROLE_CREATEDATE, Element.ROLE_UPDATEDATE);
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
            var ObjRole = (Role)entity;
            var lst = new List<T>();
            List<Role> MyList = new List<Role>();
            var Query = Context.SP_CRUD_ROLE((int)CrudActionEnum.SuperRetrieveByName, ObjRole.IdSession, ObjRole.ID_role,
                ObjRole.Name_role, ObjRole.Descrip_role).ToList();
            foreach (SP_CRUD_ROLEResult Element in Query)
            {
                Role Obj = new Role(Element.ID_ROLE, Element.NAME_ROLE, Element.DESCRIP_ROLE, Element.ROLE_STATE, Element.ROLE_CREATEBY,
                    Element.ROLE_UPDATEDBY, Element.ROLE_CREATEDATE,Element.ROLE_UPDATEDATE);
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
            var ObjRole = (Role)entity;
            Context.SP_CRUD_ROLE((int)CrudActionEnum.Update, ObjRole.UpdateBy, ObjRole.ID_role, ObjRole.Name_role, ObjRole.Descrip_role);
            return true;
        }
    }
}
