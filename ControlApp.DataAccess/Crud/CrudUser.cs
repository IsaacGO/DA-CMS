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
    public class CrudUser : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();

        public override bool Activate(BaseEntity entity)
        {

            var ObjUser = (User)entity;
            Context.SP_CRUD_USER((int)CrudActionEnum.Activate, ObjUser.UpdateBy, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass);
            return true;
        }
        public override bool Create(BaseEntity entity)
        {
            var ObjUser = (User)entity;
            Context.SP_CRUD_USER((int)CrudActionEnum.Create, ObjUser.CreateBy, ObjUser.ID_User, ObjUser.User_name,ObjUser.User_email
                ,ObjUser.ID_Dpt, ObjUser.ID_area,ObjUser.ID_position,ObjUser.ID_Role,ObjUser.User_nickname,ObjUser.User_pass);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {

            var ObjUser = (User)entity;
            Context.SP_CRUD_USER((int)CrudActionEnum.Delete, ObjUser.UpdateBy, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass);
            return true;
        }
        public override List<T> SuperRetrieve<T>()
        {
            var ObjUser = new User();
            var lst = new List<T>();
            List<User> MyList = new List<User>();
            var Query = Context.SP_CRUD_USER((int)CrudActionEnum.SuperRetrieve, ObjUser.IdSession, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass).ToList();
            foreach (SP_CRUD_USERResult Element in Query)
            {
                User Obj = new User(Element.ID_USER, Element.USER_NAME, Element.USER_EMAIL, Element.NAME_DPT,Element.AREA_NAME,Element.NAME_POSITION,
                    Element.NAME_ROLE,Element.USER_NICKNAME,Element.USER_PASSWORD, Element.USER_STATE, Element.USER_CREATEBY, Element.USER_UPDATEDBY, 
                    Element.USER_CREATEDATE,Element.USER_UPDATEDATE);
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
            var ObjUser = new User();
            var lst = new List<T>();
            List<User> MyList = new List<User>();
            var Query = Context.SP_CRUD_USER((int)CrudActionEnum.SuperRetrieveById, ObjUser.IdSession, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass).ToList();
            foreach (SP_CRUD_USERResult Element in Query)
            {
                User Obj = new User(Element.ID_USER, Element.USER_NAME, Element.USER_EMAIL, Element.NAME_DPT, Element.AREA_NAME, Element.NAME_POSITION,
                    Element.NAME_ROLE, Element.USER_NICKNAME, Element.USER_PASSWORD, Element.USER_STATE, Element.USER_CREATEBY, Element.USER_UPDATEDBY,
                    Element.USER_CREATEDATE, Element.USER_UPDATEDATE);
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
            var ObjUser = new User();
            var lst = new List<T>();
            List<User> MyList = new List<User>();
            var Query = Context.SP_CRUD_USER((int)CrudActionEnum.SuperRetrieveByName, ObjUser.IdSession, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass).ToList();
            foreach (SP_CRUD_USERResult Element in Query)
            {
                User Obj = new User(Element.ID_USER, Element.USER_NAME, Element.USER_EMAIL, Element.NAME_DPT, Element.AREA_NAME, Element.NAME_POSITION,
                    Element.NAME_ROLE, Element.USER_NICKNAME, Element.USER_PASSWORD, Element.USER_STATE, Element.USER_CREATEBY, Element.USER_UPDATEDBY,
                    Element.USER_CREATEDATE, Element.USER_UPDATEDATE);
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
            var ObjUser = new User();
            var lst = new List<T>();
            List<User> MyList = new List<User>();
            var Query = Context.SP_CRUD_USER((int)CrudActionEnum.RetrieveAll, ObjUser.IdSession, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass).ToList();
            foreach (SP_CRUD_USERResult Element in Query)
            {
                User Obj = new User(Element.ID_USER, Element.USER_NAME, Element.USER_EMAIL, Element.NAME_DPT, Element.AREA_NAME, Element.NAME_POSITION,
                    Element.NAME_ROLE, Element.USER_NICKNAME, Element.USER_PASSWORD);
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
            var ObjUser = new User();
            var lst = new List<T>();
            List<User> MyList = new List<User>();
            var Query = Context.SP_CRUD_USER((int)CrudActionEnum.RetrieveById, ObjUser.IdSession, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass).ToList();
            foreach (SP_CRUD_USERResult Element in Query)
            {
                User Obj = new User(Element.ID_USER, Element.USER_NAME, Element.USER_EMAIL, Element.NAME_DPT, Element.AREA_NAME, Element.NAME_POSITION,
                    Element.NAME_ROLE, Element.USER_NICKNAME, Element.USER_PASSWORD);
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
            var ObjUser = new User();
            var lst = new List<T>();
            List<User> MyList = new List<User>();
            var Query = Context.SP_CRUD_USER((int)CrudActionEnum.RetrieveByName, ObjUser.IdSession, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass).ToList();
            foreach (SP_CRUD_USERResult Element in Query)
            {
                User Obj = new User(Element.ID_USER, Element.USER_NAME, Element.USER_EMAIL, Element.NAME_DPT, Element.AREA_NAME, Element.NAME_POSITION,
                    Element.NAME_ROLE, Element.USER_NICKNAME, Element.USER_PASSWORD);
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

            var ObjUser = (User)entity;
            Context.SP_CRUD_USER((int)CrudActionEnum.Update, ObjUser.UpdateBy, ObjUser.ID_User, ObjUser.User_name, ObjUser.User_email
                , ObjUser.ID_Dpt, ObjUser.ID_area, ObjUser.ID_position, ObjUser.ID_Role, ObjUser.User_nickname, ObjUser.User_pass);
            return true;
        }
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
