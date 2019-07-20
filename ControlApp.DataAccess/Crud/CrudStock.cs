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
    public class CrudStock : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        Stock ObjStock = new Stock();
        public override bool Activate(BaseEntity entity)
        {
            var ObjStock = (Stock)entity;
            Context.SP_CRUD_STOCK((int)CrudActionEnum.Activate, ObjStock.CreateBy, ObjStock.Id_Stock, ObjStock.Id_Product,
                ObjStock.Stock_Initial_Quantity, ObjStock.Stock_Quantity, ObjStock.Stock_Adjustment, ObjStock.Stock_Date_Product);
            return true;
        }
        public override bool Create(BaseEntity entity)
        {
            var ObjStock = (Stock)entity;
            Context.SP_CRUD_STOCK((int)CrudActionEnum.Create, ObjStock.CreateBy, ObjStock.Id_Stock, ObjStock.Id_Product,
                ObjStock.Stock_Initial_Quantity, ObjStock.Stock_Quantity, ObjStock.Stock_Adjustment,ObjStock.Stock_Date_Product);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjStock = (Stock)entity;
            Context.SP_CRUD_STOCK((int)CrudActionEnum.Delete, ObjStock.CreateBy, ObjStock.Id_Stock, ObjStock.Id_Product,
                ObjStock.Stock_Initial_Quantity, ObjStock.Stock_Quantity, ObjStock.Stock_Adjustment, ObjStock.Stock_Date_Product);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var ObjStock = new Stock();
            var lst = new List<T>();
            List<Stock> MyList = new List<Stock>();
            var Query = Context.SP_CRUD_STOCK((int)CrudActionEnum.RetrieveAll, ObjStock.CreateBy, ObjStock.Id_Stock, ObjStock.Id_Product,
                ObjStock.Stock_Initial_Quantity, ObjStock.Stock_Quantity, ObjStock.Stock_Adjustment, ObjStock.Stock_Date_Product).ToList();
            foreach (SP_CRUD_STOCKResult Element in Query)
            {
                Stock Obj = new Stock(Element.ID_STOCK, Element.DESCRIP_PRICE, Element.STOCK_INITIAL_QUANTITY, Element.STOCK_QUANTITY
                    , Element.STOCK_ADJUSTMENT, Element.STOCK_DATE_PRODUCT);
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
            var ObjStock = (Stock)entity;
            var lst = new List<T>();
            List<Stock> MyList = new List<Stock>();
            var Query = Context.SP_CRUD_STOCK((int)CrudActionEnum.RetrieveById, ObjStock.CreateBy, ObjStock.Id_Stock, ObjStock.Id_Product,
                ObjStock.Stock_Initial_Quantity, ObjStock.Stock_Quantity, ObjStock.Stock_Adjustment, ObjStock.Stock_Date_Product).ToList();
            foreach (SP_CRUD_STOCKResult Element in Query)
            {
                Stock Obj = new Stock(Element.ID_STOCK, Element.DESCRIP_PRICE, Element.STOCK_INITIAL_QUANTITY, Element.STOCK_QUANTITY
                    , Element.STOCK_ADJUSTMENT, Element.STOCK_DATE_PRODUCT);
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
            throw new NotImplementedException();
        }
        public override List<T> SuperRetrieve<T>()
        {
            var ObjStock = new Stock();
            var lst = new List<T>();
            List<Stock> MyList = new List<Stock>();
            var Query = Context.SP_CRUD_STOCK((int)CrudActionEnum.SuperRetrieve, ObjStock.CreateBy, ObjStock.Id_Stock, ObjStock.Id_Product,
                ObjStock.Stock_Initial_Quantity, ObjStock.Stock_Quantity, ObjStock.Stock_Adjustment, ObjStock.Stock_Date_Product).ToList();
            foreach (SP_CRUD_STOCKResult Element in Query)
            {
                Stock Obj = new Stock(Element.ID_STOCK, Element.DESCRIP_PRICE, Element.STOCK_INITIAL_QUANTITY, Element.STOCK_QUANTITY
                    , Element.STOCK_ADJUSTMENT, Element.STOCK_DATE_PRODUCT,Element.STOCK_STATE, Element.STOCK_CREATEBY
                    ,Element.STOCK_UPDATEDBY,Element.STOCK_CREATEDATE, Element.STOCK_UPDATEDATE);
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
            var ObjStock = (Stock)entity;
            var lst = new List<T>();
            List<Stock> MyList = new List<Stock>();
            var Query = Context.SP_CRUD_STOCK((int)CrudActionEnum.SuperRetrieveById, ObjStock.CreateBy, ObjStock.Id_Stock, ObjStock.Id_Product,
                ObjStock.Stock_Initial_Quantity, ObjStock.Stock_Quantity, ObjStock.Stock_Adjustment, ObjStock.Stock_Date_Product).ToList();
            foreach (SP_CRUD_STOCKResult Element in Query)
            {
                Stock Obj = new Stock(Element.ID_STOCK, Element.DESCRIP_PRICE, Element.STOCK_INITIAL_QUANTITY, Element.STOCK_QUANTITY
                    , Element.STOCK_ADJUSTMENT, Element.STOCK_DATE_PRODUCT, Element.STOCK_STATE, Element.STOCK_CREATEBY
                    , Element.STOCK_UPDATEDBY, Element.STOCK_CREATEDATE, Element.STOCK_UPDATEDATE);
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
            throw new NotImplementedException();
        }
        public override bool Update(BaseEntity entity)
        {
            var ObjStock = (Stock)entity;
            Context.SP_CRUD_STOCK((int)CrudActionEnum.Update, ObjStock.CreateBy, ObjStock.Id_Stock, ObjStock.Id_Product,
                ObjStock.Stock_Initial_Quantity, ObjStock.Stock_Quantity, ObjStock.Stock_Adjustment, ObjStock.Stock_Date_Product);
            return true;
        }
    }
}
