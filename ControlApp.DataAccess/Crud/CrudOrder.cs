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
    public class CrudOrder : CrudFactory
    {

        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        Order ObjOrder = new Order();
        public override bool Create(BaseEntity entity)
        {
            var ObjOrder = (Order)entity;
            Context.SP_CRUD_ORDER((int)CrudActionEnum.Create, ObjOrder.CreateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid, ObjOrder.Order_Quantity
                ,ObjOrder.Order_Date, ObjOrder.Order_Delivery);
            return true;
        }
        public override bool Activate(BaseEntity entity)
        {
            var ObjOrder = (Order)entity;
            Context.SP_CRUD_ORDER((int)CrudActionEnum.Activate, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid, ObjOrder.Order_Quantity
                , ObjOrder.Order_Date, ObjOrder.Order_Delivery);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjOrder = (Order)entity;
            Context.SP_CRUD_ORDER((int)CrudActionEnum.Delete, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid, ObjOrder.Order_Quantity
                , ObjOrder.Order_Date, ObjOrder.Order_Delivery);
            return true;
        }

        public override List<T> RetrieveAll<T>()
        {
            
            var lst = new List<T>();
            List<Order> MyList = new List<Order>();
            var Query = Context.SP_CRUD_ORDER((int)CrudActionEnum.RetrieveAll, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid, 
                ObjOrder.Order_Quantity, ObjOrder.Order_Date, ObjOrder.Order_Delivery).ToList();
            foreach (SP_CRUD_ORDERResult  Element in Query)
            {
                Order Obj = new Order(Element.ID_ORDER, Element.ID_PREPAID, Element.ORDER_QUANTITY, Element.ORDER_DATE, 
                    Element.ORDER_DELIVERY);
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
            var ObjOrder = (Order)entity;
            var lst = new List<T>();
            List<Order> MyList = new List<Order>();
            var Query = Context.SP_CRUD_ORDER((int)CrudActionEnum.RetrieveById, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid,
                ObjOrder.Order_Quantity
                , ObjOrder.Order_Date, ObjOrder.Order_Delivery).ToList();
            foreach (SP_CRUD_ORDERResult Element in Query)
            {
                Order Obj = new Order(Element.ID_ORDER, Element.ID_PREPAID, Element.ORDER_QUANTITY, Element.ORDER_DATE,
                    Element.ORDER_DELIVERY);
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
            var ObjOrder = (Order)entity;
            var lst = new List<T>();
            List<Order> MyList = new List<Order>();
            var Query = Context.SP_CRUD_ORDER((int)CrudActionEnum.RetrieveByName, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid,
                ObjOrder.Order_Quantity
                , ObjOrder.Order_Date, ObjOrder.Order_Delivery).ToList();
            foreach (SP_CRUD_ORDERResult Element in Query)
            {
                Order Obj = new Order(Element.ID_ORDER, Element.ID_PREPAID, Element.ORDER_QUANTITY, Element.ORDER_DATE,
                    Element.ORDER_DELIVERY);
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
            var ObjOrder = new Order();
            var lst = new List<T>();
            List<Order> MyList = new List<Order>();
            var Query = Context.SP_CRUD_ORDER((int)CrudActionEnum.SuperRetrieve, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid,
                ObjOrder.Order_Quantity
                , ObjOrder.Order_Date, ObjOrder.Order_Delivery).ToList();
            foreach (SP_CRUD_ORDERResult Element in Query)
            {
                Order Obj = new Order(Element.ID_ORDER, Element.ID_PREPAID, Element.ORDER_QUANTITY, Element.ORDER_DATE,
                    Element.ORDER_DELIVERY, Element.ORDER_STATE, Element.ORDER_CREATEBY,Element.ORDER_UPDATEDBY,
                    Element.ORDER_CREATEDATE,Element.ORDER_UPDATEDATE);
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
            var ObjOrder = (Order)entity;
            var lst = new List<T>();
            List<Order> MyList = new List<Order>();
            var Query = Context.SP_CRUD_ORDER((int)CrudActionEnum.SuperRetrieveById, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid,
                ObjOrder.Order_Quantity
                , ObjOrder.Order_Date, ObjOrder.Order_Delivery).ToList();
            foreach (SP_CRUD_ORDERResult Element in Query)
            {
                Order Obj = new Order(Element.ID_ORDER, Element.ID_PREPAID, Element.ORDER_QUANTITY, Element.ORDER_DATE,
                    Element.ORDER_DELIVERY, Element.ORDER_STATE, Element.ORDER_CREATEBY, Element.ORDER_UPDATEDBY,
                    Element.ORDER_CREATEDATE, Element.ORDER_UPDATEDATE);
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
            var ObjOrder = (Order)entity;
            var lst = new List<T>();
            List<Order> MyList = new List<Order>();
            var Query = Context.SP_CRUD_ORDER((int)CrudActionEnum.SuperRetrieveByName, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid,
                ObjOrder.Order_Quantity
                , ObjOrder.Order_Date, ObjOrder.Order_Delivery).ToList();
            foreach (SP_CRUD_ORDERResult Element in Query)
            {
                Order Obj = new Order(Element.ID_ORDER, Element.ID_PREPAID, Element.ORDER_QUANTITY, Element.ORDER_DATE,
                    Element.ORDER_DELIVERY, Element.ORDER_STATE, Element.ORDER_CREATEBY, Element.ORDER_UPDATEDBY,
                    Element.ORDER_CREATEDATE, Element.ORDER_UPDATEDATE);
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
            var ObjOrder = (Order)entity;
            Context.SP_CRUD_ORDER((int)CrudActionEnum.Update, ObjOrder.UpdateBy, ObjOrder.Id_Order, ObjOrder.Id_Prepaid, ObjOrder.Order_Quantity
                , ObjOrder.Order_Date, ObjOrder.Order_Delivery);
            return true;
        }
    }
}
