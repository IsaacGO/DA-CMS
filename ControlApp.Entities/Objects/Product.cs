using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Product : BaseEntity
    {
        public int ID_Product { get; set; }
        public decimal Total_Product { get; set; }
        public string Descrip_Price { get; set; }
        public Product()
        {
            ID_Product = 0;
            Total_Product = 0;
            Descrip_Price = "Null";
        
        }
        public Product(int pID_Product, decimal pTotal_Product, string pDescrip_Price)
        {
            this.ID_Product = pID_Product;
            this.Total_Product = pTotal_Product;
            this.Descrip_Price = pDescrip_Price;
        }
        public Product(int pID_Product, decimal pTotal_Product, string pDescrip_Price, bool pState, string pCreateBy, string pUpdatedBy, DateTime pCreateDate,
            DateTime? pUpdateDate)
        {
            this.ID_Product = pID_Product;
            this.Total_Product = Math.Round(pTotal_Product, 2);
            this.Descrip_Price = pDescrip_Price;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
        public Product(int pID_Product,string pIdSession, decimal pTotal_Product, string pDescrip_Price, bool pState, string pCreateBy, string pUpdatedBy, 
            DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.ID_Product = pID_Product;
            this.Total_Product = Math.Round(pTotal_Product, 2);
            this.IdSession = pIdSession;
            this.Descrip_Price = pDescrip_Price;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
    }

}
