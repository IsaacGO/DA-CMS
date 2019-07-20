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
    public class CrudPrepaid : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        Prepaid ObjPrepaid = new Prepaid();
        public override bool Activate(BaseEntity entity)
        {
            var ObjPrepaid = (Prepaid)entity;
            Context.SP_CRUD_PREPAID((int)CrudActionEnum.Activate, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash, 
                ObjPrepaid.Prepaid_Change,ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer);
            return true;
        }
        public override bool Create(BaseEntity entity)
        {
            var ObjPrepaid = (Prepaid)entity;
            Context.SP_CRUD_PREPAID((int)CrudActionEnum.Create, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash,
                ObjPrepaid.Prepaid_Change, ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjPrepaid = (Prepaid)entity;
            Context.SP_CRUD_PREPAID((int)CrudActionEnum.Delete, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash,
                ObjPrepaid.Prepaid_Change, ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var ObjPrepaid = new Prepaid();
            var lst = new List<T>();
            List<Prepaid> MyList = new List<Prepaid>();
            var Query = Context.SP_CRUD_PREPAID((int)CrudActionEnum.RetrieveAll, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash, ObjPrepaid.Prepaid_Change,
                ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer).ToList();
            foreach (SP_CRUD_PREPAIDResult Element in Query)
            {
                Prepaid Obj = new Prepaid(Element.ID_PREPAID, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, Element.PREPAID_QUANTITY,
                    Element.PREPAID_TOTAL, Element.PREPAID_CASH, Element.PREPAID_CHANGE, Element.PREPAID_BALANCE);
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
            var ObjPrepaid = (Prepaid)entity;
            var lst = new List<T>();
            List<Prepaid> MyList = new List<Prepaid>();
            var Query = Context.SP_CRUD_PREPAID((int)CrudActionEnum.RetrieveById, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash, ObjPrepaid.Prepaid_Change,
                ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer).ToList();
            foreach (SP_CRUD_PREPAIDResult Element in Query)
            {
                Prepaid Obj = new Prepaid(Element.ID_PREPAID, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, Element.PREPAID_QUANTITY,
                    Element.PREPAID_TOTAL, Element.PREPAID_CASH, Element.PREPAID_CHANGE, Element.PREPAID_BALANCE);
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
            var ObjPrepaid = (Prepaid)entity;
            var lst = new List<T>();
            List<Prepaid> MyList = new List<Prepaid>();
            var Query = Context.SP_CRUD_PREPAID((int)CrudActionEnum.RetrieveByName, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash, ObjPrepaid.Prepaid_Change,
                ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer).ToList();
            foreach (SP_CRUD_PREPAIDResult Element in Query)
            {
                Prepaid Obj = new Prepaid(Element.ID_PREPAID, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, Element.PREPAID_QUANTITY,
                    Element.PREPAID_TOTAL, Element.PREPAID_CASH, Element.PREPAID_CHANGE, Element.PREPAID_BALANCE);
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
            var ObjPrepaid = new Prepaid();
            var lst = new List<T>();
            List<Prepaid> MyList = new List<Prepaid>();
            var Query = Context.SP_CRUD_PREPAID((int)CrudActionEnum.SuperRetrieve, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash, ObjPrepaid.Prepaid_Change, 
                ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer).ToList();
            foreach (SP_CRUD_PREPAIDResult Element in Query)
            {
                Prepaid Obj = new Prepaid(Element.ID_PREPAID, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, Element.PREPAID_QUANTITY,
                    Element.PREPAID_TOTAL, Element.PREPAID_CASH, Element.PREPAID_CHANGE, Element.PREPAID_BALANCE, Element.PREPAID_STATE,
                    Element.PREPAID_CREATEBY, Element.PREPAID_UPDATEDBY, Element.PREPAID_CREATEDATE, Element.PREPAID_UPDATEDATE);
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
            var ObjPrepaid = (Prepaid)entity;
            var lst = new List<T>();
            List<Prepaid> MyList = new List<Prepaid>();
            var Query = Context.SP_CRUD_PREPAID((int)CrudActionEnum.SuperRetrieveById, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash, ObjPrepaid.Prepaid_Change,
                ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer).ToList();
            foreach (SP_CRUD_PREPAIDResult Element in Query)
            {
                Prepaid Obj = new Prepaid(Element.ID_PREPAID, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, Element.PREPAID_QUANTITY,
                    Element.PREPAID_TOTAL, Element.PREPAID_CASH, Element.PREPAID_CHANGE, Element.PREPAID_BALANCE, Element.PREPAID_STATE,
                    Element.PREPAID_CREATEBY, Element.PREPAID_UPDATEDBY, Element.PREPAID_CREATEDATE, Element.PREPAID_UPDATEDATE);
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
            var ObjPrepaid = (Prepaid)entity;
            var lst = new List<T>();
            List<Prepaid> MyList = new List<Prepaid>();
            var Query = Context.SP_CRUD_PREPAID((int)CrudActionEnum.SuperRetrieveByName, ObjPrepaid.CreateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash, ObjPrepaid.Prepaid_Change,
                ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer).ToList();
            foreach (SP_CRUD_PREPAIDResult Element in Query)
            {
                Prepaid Obj = new Prepaid(Element.ID_PREPAID, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, Element.PREPAID_QUANTITY,
                    Element.PREPAID_TOTAL, Element.PREPAID_CASH, Element.PREPAID_CHANGE, Element.PREPAID_BALANCE, Element.PREPAID_STATE,
                    Element.PREPAID_CREATEBY, Element.PREPAID_UPDATEDBY, Element.PREPAID_CREATEDATE, Element.PREPAID_UPDATEDATE);
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
            var ObjPrepaid = (Prepaid)entity;
            Context.SP_CRUD_PREPAID((int)CrudActionEnum.Update, ObjPrepaid.UpdateBy, ObjPrepaid.Id_Prepaid, ObjPrepaid.Id_Customer,
                ObjPrepaid.Id_Product, ObjPrepaid.Prepaid_Quantity, ObjPrepaid.Prepaid_Total, ObjPrepaid.Prepaid_Cash,
                ObjPrepaid.Prepaid_Change, ObjPrepaid.Prepaid_Balance, ObjPrepaid.Name_Customer);
            return true;
        }
    }
}
