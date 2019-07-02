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
    public class CrudCustomer : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        Customer ObjCustomer = new Customer();
        public override bool Create(BaseEntity entity)
        {
            var ObjCustomer = (Customer)entity;
            Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.Create, ObjCustomer.CreateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name);
            return true;
        }
        public override List<T> SuperRetrieve<T>()
        {
            var ObjCustomer = new Customer();
            var lst = new List<T>();
            List<Customer> MyList = new List<Customer>();
            var Query = Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.SuperRetrieve, ObjCustomer.CreateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name).ToList();
            foreach (SP_CRUD_CUSTOMERResult Element in Query)
            {
                Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE, Element.CUSTOMER_CREATEBY,
                    Element.CUSTOMER_UPDATEDBY, Element.CUSTOMER_CREATEDATE, Element.CUSTOMER_UPDATEDATE);
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
        public override List<T> SuperRetrieveById<T>(BaseEntity entity)
        {
            var ObjCustomer = (Customer)entity;
            var lst = new List<T>();
            List<Customer> MyList = new List<Customer>();
            var Query = Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.SuperRetrieveById, ObjCustomer.CreateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name).ToList();
            foreach (SP_CRUD_CUSTOMERResult Element in Query)
            {
                Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE, Element.CUSTOMER_CREATEBY,
                    Element.CUSTOMER_UPDATEDBY, Element.CUSTOMER_CREATEDATE, Element.CUSTOMER_UPDATEDATE);
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
            var ObjCustomer = (Customer)entity;
            var lst = new List<T>();
            List<Customer> MyList = new List<Customer>();
            var Query = Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.SuperRetrieveByName, ObjCustomer.CreateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name).ToList();
            foreach (SP_CRUD_CUSTOMERResult Element in Query)
            {
                Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME, Element.CUSTOMER_STATE, Element.CUSTOMER_CREATEBY,
                    Element.CUSTOMER_UPDATEDBY, Element.CUSTOMER_CREATEDATE, Element.CUSTOMER_UPDATEDATE);
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
            var ObjCustomer = new Customer();
            var lst = new List<T>();
            List<Customer> MyList = new List<Customer>();
            var Query = Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.RetrieveAll, ObjCustomer.CreateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name).ToList();
            foreach (SP_CRUD_CUSTOMERResult Element in Query)
            {
                Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME);
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
            var ObjCustomer = (Customer)entity;
            var lst = new List<T>();
            List<Customer> MyList = new List<Customer>();
            var Query = Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.RetrieveById, ObjCustomer.CreateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name).ToList();
            foreach (SP_CRUD_CUSTOMERResult Element in Query)
            {
                Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME);
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
            var ObjCustomer = (Customer)entity;
            var lst = new List<T>();
            List<Customer> MyList = new List<Customer>();
            var Query = Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.RetrieveByName, ObjCustomer.CreateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name).ToList();
            foreach (SP_CRUD_CUSTOMERResult Element in Query)
            {
                Customer Obj = new Customer(Element.ID_CUSTOMER, Element.CUSTOMER_NAME);
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
            var ObjCustomer = (Customer)entity;
            Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.Update, ObjCustomer.UpdateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjCustomer = (Customer)entity;
            Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.Delete, ObjCustomer.UpdateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name);
            return true;
        }
        public override bool Activate(BaseEntity entity)
        {
            var ObjCustomer = (Customer)entity;
            Context.SP_CRUD_CUSTOMER((int)CrudActionEnum.Activate, ObjCustomer.UpdateBy, ObjCustomer.ID_Customer, ObjCustomer.Customer_name);
            return true;
        }
    }
}