using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Entities.Objects;
using System.Data.Linq; // Manipulacion de bases de datos SQL
using System.Data.Linq.Mapping; // otra clase por importar para la Manipulacion

namespace ControlApp.DataAccess.Crud
{
    public class CrudAccountreceivable : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        Accountreceivable ObjCxc = new Accountreceivable();
        public override bool Activate(BaseEntity entity)
        {
            var ObjCxc = (Accountreceivable)entity;
            Context.SP_CRUD_CXC((int)CrudActionEnum.Activate, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, ObjCxc.Id_Product,
            ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer, ObjCxc.Name_Product);
            return true;
        }

        public override bool Create(BaseEntity entity)
        {
            var ObjCxc = (Accountreceivable)entity;
            Context.SP_CRUD_CXC((int)CrudActionEnum.Create, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, ObjCxc.Id_Product,
            ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer, ObjCxc.Name_Product);
            return true;
        }

        public override bool Delete(BaseEntity entity)
        {
            var ObjCxc = (Accountreceivable)entity;
            Context.SP_CRUD_CXC((int)CrudActionEnum.Delete, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, ObjCxc.Id_Product,
            ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer, ObjCxc.Name_Product);
            return true;
        }

        public override List<T> RetrieveAll<T>()
        {
            var ObjCxc = new Accountreceivable();
            var lst = new List<T>();
            List<Accountreceivable> MyList = new List<Accountreceivable>();
            var Query = Context.SP_CRUD_CXC((int)CrudActionEnum.RetrieveAll, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, ObjCxc.Id_Product,
            ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer, 
            ObjCxc.Name_Product).ToList();
            foreach (SP_CRUD_CXCResult Element in Query)
            {
                Accountreceivable Obj = new Accountreceivable(Element.ID_CXC, Element.CUSTOMER_NAME,Element.DESCRIP_PRICE,Element.QUANTITY_RETREAT
                    ,Element.QUANTITY_RETURN,Element.TOTAL_CXC,Element.BALANCE_CXC);
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
            var ObjCxc = (Accountreceivable)entity;
            var lst = new List<T>();
            List<Accountreceivable> MyList = new List<Accountreceivable>();
            var Query = Context.SP_CRUD_CXC((int)CrudActionEnum.RetrieveById, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, ObjCxc.Id_Product,
            ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer,
            ObjCxc.Name_Product).ToList();
            foreach (SP_CRUD_CXCResult Element in Query)
            {
                Accountreceivable Obj = new Accountreceivable(Element.ID_CXC, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, Element.QUANTITY_RETREAT
                    , Element.QUANTITY_RETURN, Element.TOTAL_CXC, Element.BALANCE_CXC);
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
            var ObjCxc = (Accountreceivable)entity;
            var lst = new List<T>();
            List<Accountreceivable> MyList = new List<Accountreceivable>();
            var Query = Context.SP_CRUD_CXC((int)CrudActionEnum.RetrieveByName, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, 
            ObjCxc.Id_Product, ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer,
            ObjCxc.Name_Product).ToList();
            foreach (SP_CRUD_CXCResult Element in Query)
            {
            Accountreceivable Obj = new Accountreceivable(Element.ID_CXC, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, Element.QUANTITY_RETREAT
                    , Element.QUANTITY_RETURN, Element.TOTAL_CXC, Element.BALANCE_CXC);
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
            var ObjCxc = new Accountreceivable();
            var lst = new List<T>();
            List<Accountreceivable> MyList = new List<Accountreceivable>();
            var Query = Context.SP_CRUD_CXC((int)CrudActionEnum.SuperRetrieve, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, ObjCxc.Id_Product,
            ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer,
            ObjCxc.Name_Product).ToList();
            foreach (SP_CRUD_CXCResult Element in Query)
            {
                Accountreceivable Obj = new Accountreceivable(Element.ID_CXC, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE, 
                Element.QUANTITY_RETREAT,Element.QUANTITY_RETURN, Element.TOTAL_CXC, Element.BALANCE_CXC,Element.CXC_STATE,Element.CXC_CREATEBY
                ,Element.CXC_UPDATEDBY,Element.CXC_CREATEDATE,Element.CXC_UPDATEDATE);
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
            var ObjCxc = (Accountreceivable)entity;
            var lst = new List<T>();
            List<Accountreceivable> MyList = new List<Accountreceivable>();
            var Query = Context.SP_CRUD_CXC((int)CrudActionEnum.SuperRetrieveById, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, 
            ObjCxc.Id_Product, ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer,
            ObjCxc.Name_Product).ToList();
            foreach (SP_CRUD_CXCResult Element in Query)
            {
                Accountreceivable Obj = new Accountreceivable(Element.ID_CXC, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE,
                Element.QUANTITY_RETREAT, Element.QUANTITY_RETURN, Element.TOTAL_CXC, Element.BALANCE_CXC, Element.CXC_STATE, Element.CXC_CREATEBY
                , Element.CXC_UPDATEDBY, Element.CXC_CREATEDATE, Element.CXC_UPDATEDATE);
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
            var ObjCxc = (Accountreceivable)entity;
            var lst = new List<T>();
            List<Accountreceivable> MyList = new List<Accountreceivable>();
            var Query = Context.SP_CRUD_CXC((int)CrudActionEnum.SuperRetrieveByName, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer,
            ObjCxc.Id_Product, ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer,
            ObjCxc.Name_Product).ToList();
            foreach (SP_CRUD_CXCResult Element in Query)
            {
                Accountreceivable Obj = new Accountreceivable(Element.ID_CXC, Element.CUSTOMER_NAME, Element.DESCRIP_PRICE,
                Element.QUANTITY_RETREAT, Element.QUANTITY_RETURN, Element.TOTAL_CXC, Element.BALANCE_CXC, Element.CXC_STATE, Element.CXC_CREATEBY
                , Element.CXC_UPDATEDBY, Element.CXC_CREATEDATE, Element.CXC_UPDATEDATE);
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
            var ObjCxc = (Accountreceivable)entity;
            Context.SP_CRUD_CXC((int)CrudActionEnum.Update, ObjCxc.CreateBy, ObjCxc.Id_Cxc, ObjCxc.Id_Customer, ObjCxc.Id_Product,
            ObjCxc.Quantity_Retreat, ObjCxc.Quantity_Return, ObjCxc.Total_Cxc, ObjCxc.Balance_Cxc, ObjCxc.Name_Customer, ObjCxc.Name_Product);
            return true;
        }
    }
}
