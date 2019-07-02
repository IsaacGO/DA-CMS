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
    public class CrudProduct : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        Product ObjProduct = new Product();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (Product)entity;
            Context.SP_CRUD_PRODUCT((int)CrudActionEnum.Create,Obj.IdSession, Obj.ID_Product, Obj.Total_Product, Obj.Descrip_Price);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var lst = new List<T>();
            List<Product> MyList = new List<Product>();
            var Query = Context.SP_CRUD_PRODUCT((int)CrudActionEnum.RetrieveAll, ObjProduct.IdSession,
               ObjProduct.ID_Product, ObjProduct.Total_Product, ObjProduct.Descrip_Price).ToList();
            foreach (SP_CRUD_PRODUCTResult Element in Query)
            {
                Product Obj = new Product(Element.ID_PRODUCT, Element.TOTAL_PRODUCT, Element.DESCRIP_PRICE);
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
            var Obj = (Product)entity;
            Context.SP_CRUD_PRODUCT((int)CrudActionEnum.Update, Obj.UpdateBy, Obj.ID_Product, Obj.Total_Product, Obj.Descrip_Price);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (Product)entity;
            Context.SP_CRUD_PRODUCT((int)CrudActionEnum.Delete, Obj.UpdateBy, Obj.ID_Product, Obj.Total_Product, Obj.Descrip_Price);
            return true;
        }
        public override List<T> SuperRetrieve<T>()
        {
            var lst = new List<T>();
            List<Product> MyList = new List<Product>();
            var Query = Context.SP_CRUD_PRODUCT((int)CrudActionEnum.SuperRetrieve, ObjProduct.IdSession,
                ObjProduct.ID_Product, ObjProduct.Total_Product, ObjProduct.Descrip_Price).ToList();
            foreach (SP_CRUD_PRODUCTResult Element in Query)
            {
                Product Obj = new Product(Element.ID_PRODUCT, Element.TOTAL_PRODUCT, Element.DESCRIP_PRICE, Element.PRODUCT_STATE,
                    Element.PRICE_TAG_CREATEBY, Element.PRICE_TAG_UPDATEDBY, Element.PRODUCT_CREATEDATE, Element.PRODUCT_UPDATEDATE);
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
            var Obj = (Product)entity;
            var lst = new List<T>();
            List<Product> MyList = new List<Product>();
            var Query = Context.SP_CRUD_PRODUCT((int)CrudActionEnum.SuperRetrieveById, Obj.IdSession,
               Obj.ID_Product, Obj.Total_Product, Obj.Descrip_Price).ToList();
            foreach (SP_CRUD_PRODUCTResult Element in Query)
            {
                Product ObjProduct = new Product(Element.ID_PRODUCT, Element.TOTAL_PRODUCT, Element.DESCRIP_PRICE, Element.PRODUCT_STATE,
                    Element.PRICE_TAG_CREATEBY, Element.PRICE_TAG_UPDATEDBY, Element.PRODUCT_CREATEDATE, Element.PRODUCT_UPDATEDATE);
                MyList.Add(ObjProduct);
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
            var Obj = (Product)entity;
            var lst = new List<T>();
            List<Product> MyList = new List<Product>();
            var Query = Context.SP_CRUD_PRODUCT((int)CrudActionEnum.SuperRetrieveByName, Obj.IdSession,
                        Obj.ID_Product, Obj.Total_Product, Obj.Descrip_Price).ToList();
            foreach (SP_CRUD_PRODUCTResult Element in Query)
            {
                Product ObjProduct = new Product(Element.ID_PRODUCT, Element.TOTAL_PRODUCT, Element.DESCRIP_PRICE, Element.PRODUCT_STATE,
                    Element.PRICE_TAG_CREATEBY, Element.PRICE_TAG_UPDATEDBY, Element.PRODUCT_CREATEDATE, Element.PRODUCT_UPDATEDATE);
                MyList.Add(ObjProduct);
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
            var Obj = (Product)entity;
            var lst = new List<T>();
            List<Product> MyList = new List<Product>();
            var Query = Context.SP_CRUD_PRODUCT((int)CrudActionEnum.RetrieveById, Obj.IdSession,
                        Obj.ID_Product, Obj.Total_Product, Obj.Descrip_Price).ToList();
            foreach (SP_CRUD_PRODUCTResult Element in Query)
            {
                Product ObjProduct = new Product(Element.ID_PRODUCT, Element.TOTAL_PRODUCT, Element.DESCRIP_PRICE);
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
            var Obj = (Product)entity;
            var lst = new List<T>();
            List<Product> MyList = new List<Product>();
            var Query = Context.SP_CRUD_PRODUCT((int)CrudActionEnum.RetrieveByName, Obj.IdSession,
                        Obj.ID_Product, Obj.Total_Product, Obj.Descrip_Price).ToList();
            foreach (SP_CRUD_PRODUCTResult Element in Query)
            {
                Product ObjProduct = new Product(Element.ID_PRODUCT, Element.TOTAL_PRODUCT, Element.DESCRIP_PRICE);
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
            var Obj = (Product)entity;
            Context.SP_CRUD_PRODUCT((int)CrudActionEnum.Activate, Obj.UpdateBy, Obj.ID_Product, Obj.Total_Product, Obj.Descrip_Price);
            return true;
        }
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
