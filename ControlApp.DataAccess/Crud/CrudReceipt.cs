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
    public class CrudReceipt : CrudFactory 
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        Receipt ObjReceipt = new Receipt();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (Receipt)entity;
            //Calculo
            Obj.Total_Receipt = Obj.Unit_Price * Obj.Quantity;
            //\\
            Context.SP_CRUD_RECEIPT((int)CrudActionEnum.Create, Obj.ID_Receipt, Obj.IdSession,
                Obj.Customer_name,Obj.Quantity, Obj.Total_Receipt,Obj.ID_Price_tag,Obj.Unit_Price,
                Obj.Cash, Obj.Change);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var lst = new List<T>();
            List<Receipt> MyList = new List<Receipt>();
            var Query = Context.SP_CRUD_RECEIPT((int)CrudActionEnum.RetrieveAll, ObjReceipt.ID_Receipt, ObjReceipt.IdSession,
                ObjReceipt.Customer_name, ObjReceipt.Quantity, ObjReceipt.Total_Receipt, ObjReceipt.ID_Price_tag, 
                ObjReceipt.Unit_Price,ObjReceipt.Cash,ObjReceipt.Change).ToList();
            foreach (SP_CRUD_RECEIPTResult Element in Query)
            {
                Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.NAME_CUSTOMER, Element.DATE_RECEIPT, 
                    Element.QUANTITY, Element.TOTAL_RECEIPT, Element.DESCRIP_PRICE,Element.UNIT_PRICE, Element.CASH,
                    Element.CHANGE);
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
            var Obj = (Receipt)entity;
            //Calculo
            Obj.Total_Receipt = Obj.Unit_Price * Obj.Quantity;
            //\\
            Context.SP_CRUD_RECEIPT((int)CrudActionEnum.Update, Obj.ID_Receipt, Obj.IdSession,
                Obj.Customer_name, Obj.Quantity, Obj.Total_Receipt, Obj.ID_Price_tag, Obj.Unit_Price,
                Obj.Cash, Obj.Change);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (Receipt)entity;
            Context.SP_CRUD_RECEIPT((int)CrudActionEnum.Delete, Obj.ID_Receipt, Obj.IdSession,
                Obj.Customer_name, Obj.Quantity, Obj.Total_Receipt, Obj.ID_Price_tag, Obj.Unit_Price,
                Obj.Cash, Obj.Change);
            return true;
        }
        public override List<T> SuperRetrieve<T>()
        {
            var lst = new List<T>();
            List<Receipt> MyList = new List<Receipt>();
            var Query = Context.SP_CRUD_RECEIPT((int)CrudActionEnum.SuperRetrieve, ObjReceipt.ID_Receipt, ObjReceipt.IdSession,
                ObjReceipt.Customer_name, ObjReceipt.Quantity, ObjReceipt.Total_Receipt, ObjReceipt.ID_Price_tag, ObjReceipt.Unit_Price,
                ObjReceipt.Cash, ObjReceipt.Change).ToList();
            foreach (SP_CRUD_RECEIPTResult Element in Query)
            {
                Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.NAME_CUSTOMER, Element.DATE_RECEIPT,
                    Element.QUANTITY, Element.TOTAL_RECEIPT, Element.DESCRIP_PRICE,
                    Element.UNIT_PRICE,Element.CASH, Element.CHANGE,Element.RECEIPT_STATE, Element.RECEIPT_CREATEBY, Element.RECEIPT_UPDATEDBY, 
                    Element.RECEIPT_CREATEDATE, Element.RECEIPT_UPDATEDATE);
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
            var ObjReceipt = (Receipt)entity;
            var lst = new List<T>();
            List<Receipt> MyList = new List<Receipt>();
            var Query = Context.SP_CRUD_RECEIPT((int)CrudActionEnum.SuperRetrieveById, ObjReceipt.ID_Receipt, ObjReceipt.IdSession,
                ObjReceipt.Customer_name, ObjReceipt.Quantity, ObjReceipt.Total_Receipt, ObjReceipt.ID_Price_tag, ObjReceipt.Unit_Price,
                ObjReceipt.Cash, ObjReceipt.Change).ToList();
            foreach (SP_CRUD_RECEIPTResult Element in Query)
            {
                Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.NAME_CUSTOMER, Element.DATE_RECEIPT,
                    Element.QUANTITY, Element.TOTAL_RECEIPT, Element.DESCRIP_PRICE,
                    Element.UNIT_PRICE, Element.CASH, Element.CHANGE, Element.RECEIPT_STATE, 
                    Element.RECEIPT_CREATEBY, Element.RECEIPT_UPDATEDBY, Element.RECEIPT_CREATEDATE,Element.RECEIPT_UPDATEDATE);
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
            var ObjReceipt = (Receipt)entity;
            var lst = new List<T>();
            List<Receipt> MyList = new List<Receipt>();
            var Query = Context.SP_CRUD_RECEIPT((int)CrudActionEnum.SuperRetrieveByName, ObjReceipt.ID_Receipt, ObjReceipt.IdSession,
                ObjReceipt.Customer_name, ObjReceipt.Quantity, ObjReceipt.Total_Receipt, ObjReceipt.ID_Price_tag, ObjReceipt.Unit_Price,
                ObjReceipt.Cash, ObjReceipt.Change).ToList();
            foreach (SP_CRUD_RECEIPTResult Element in Query)
            {
                Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.NAME_CUSTOMER, Element.DATE_RECEIPT,
                    Element.QUANTITY, Element.TOTAL_RECEIPT, Element.DESCRIP_PRICE,
                    Element.UNIT_PRICE, Element.CASH, Element.CHANGE, Element.RECEIPT_STATE, 
                    Element.RECEIPT_CREATEBY, Element.RECEIPT_UPDATEDBY, Element.RECEIPT_CREATEDATE, Element.RECEIPT_UPDATEDATE);
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
            var ObjReceipt = (Receipt)entity;
            var lst = new List<T>();
            List<Receipt> MyList = new List<Receipt>();
            var Query = Context.SP_CRUD_RECEIPT((int)CrudActionEnum.RetrieveById, ObjReceipt.ID_Receipt, ObjReceipt.IdSession,
                ObjReceipt.Customer_name, ObjReceipt.Quantity, ObjReceipt.Total_Receipt, ObjReceipt.ID_Price_tag, ObjReceipt.Unit_Price,
                ObjReceipt.Cash, ObjReceipt.Change).ToList();
            foreach (SP_CRUD_RECEIPTResult Element in Query)
            {
                Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.NAME_CUSTOMER, Element.DATE_RECEIPT,
                    Element.QUANTITY, Element.TOTAL_RECEIPT, Element.DESCRIP_PRICE, Element.UNIT_PRICE,
                    Element.CASH, Element.CHANGE);
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
            var ObjReceipt = (Receipt)entity;
            var lst = new List<T>();
            List<Receipt> MyList = new List<Receipt>();
            var Query = Context.SP_CRUD_RECEIPT((int)CrudActionEnum.RetrieveByIdUser, ObjReceipt.ID_Receipt, ObjReceipt.IdSession,
                ObjReceipt.Customer_name, ObjReceipt.Quantity, ObjReceipt.Total_Receipt, ObjReceipt.ID_Price_tag, ObjReceipt.Unit_Price,
                ObjReceipt.Cash, ObjReceipt.Change).ToList();
            foreach (SP_CRUD_RECEIPTResult Element in Query)
            {
                Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.NAME_CUSTOMER, Element.DATE_RECEIPT,
                    Element.QUANTITY, Element.TOTAL_RECEIPT, Element.DESCRIP_PRICE, Element.UNIT_PRICE,
                    Element.CASH, Element.CHANGE);
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
            var ObjReceipt = (Receipt)entity;
            var lst = new List<T>();
            List<Receipt> MyList = new List<Receipt>();
            var Query = Context.SP_CRUD_RECEIPT((int)CrudActionEnum.RetrieveByName, ObjReceipt.ID_Receipt, ObjReceipt.IdSession,
                ObjReceipt.Customer_name, ObjReceipt.Quantity, ObjReceipt.Total_Receipt, ObjReceipt.ID_Price_tag, ObjReceipt.Unit_Price,
                ObjReceipt.Cash, ObjReceipt.Change).ToList();
            foreach (SP_CRUD_RECEIPTResult Element in Query)
            {
                Receipt Obj = new Receipt(Element.ID_RECEIPT, Element.NAME_CUSTOMER, Element.DATE_RECEIPT,
                    Element.QUANTITY, Element.TOTAL_RECEIPT, Element.DESCRIP_PRICE, Element.UNIT_PRICE,
                    Element.CASH, Element.CHANGE);
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
        public override bool Activate(BaseEntity entity)
        {
            var Obj = (Receipt)entity;
            Context.SP_CRUD_RECEIPT((int)CrudActionEnum.Activate, Obj.ID_Receipt, Obj.IdSession,
                Obj.Customer_name, Obj.Quantity, Obj.Total_Receipt, Obj.ID_Price_tag, Obj.Unit_Price,
                Obj.Cash, Obj.Change);
            return true;
        }
    }
}
