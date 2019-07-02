using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Stock : BaseEntity
    {
        public int Id_Stock { get; set; }
        public int Id_Product { get; set; }
        public int Stock_Initial_Quantity { get; set; }
        public int Stock_Quantity { get; set; }
        public int Stock_Adjustment { get; set; }
        public DateTime Stock_Date_Product { get; set; }
        /// <foreigner> variables for esthetic query of UI
        public string Name_Product { get; set; }
        /// </foreigner>
        /// Default Constructor
        public Stock()
        {
            Id_Stock = 0;
            Id_Product = 0;
            Stock_Initial_Quantity = 0;
            Stock_Adjustment = 0;
            Stock_Date_Product = DateTime.Today;
        }
        public Stock(int pId_Stock, string pName_Product, int pStock_Initial_Quantity, int pStock_Quantity, int pStock_Adjustment,
           DateTime pStock_Date_Product)
        {
            this.Id_Stock = pId_Stock;
            this.Name_Product = pName_Product;
            this.Stock_Initial_Quantity = pStock_Initial_Quantity;
            this.Stock_Quantity = pStock_Quantity;
            this.Stock_Adjustment = pStock_Adjustment;
            this.Stock_Date_Product = pStock_Date_Product;
        }
        public Stock(int pId_Stock, int pId_Product, int pStock_Initial_Quantity, int pStock_Quantity, int pStock_Adjustment,
          DateTime pStock_Date_Product)
        {
            this.Id_Stock = pId_Stock;
            this.Id_Product = pId_Product;
            this.Stock_Initial_Quantity = pStock_Initial_Quantity;
            this.Stock_Quantity = pStock_Quantity;
            this.Stock_Adjustment = pStock_Adjustment;
            this.Stock_Date_Product = pStock_Date_Product;
        }
        public Stock(int pId_Stock, string pName_Product, int pStock_Initial_Quantity, int pStock_Quantity, int pStock_Adjustment,
            DateTime pStock_Date_Product, bool? pState, string pCreateBy, string pUpdateBy, DateTime pCreateDate,
            DateTime? pUpdateDate)
        {
            this.Id_Stock = pId_Stock;
            this.Name_Product = pName_Product;
            this.Stock_Initial_Quantity = pStock_Initial_Quantity;
            this.Stock_Quantity = pStock_Quantity;
            this.Stock_Adjustment = pStock_Adjustment;
            this.Stock_Date_Product = pStock_Date_Product;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
        public Stock(int pId_Stock, int pId_Product, int pStock_Initial_Quantity, int pStock_Quantity, int pStock_Adjustment,
            DateTime pStock_Date_Product, bool? pState, string pCreateBy, string pUpdateBy, DateTime pCreateDate,
            DateTime? pUpdateDate)
        {
            this.Id_Stock = pId_Stock;
            this.Id_Product = pId_Product;
            this.Stock_Initial_Quantity = pStock_Initial_Quantity;
            this.Stock_Quantity = pStock_Quantity;
            this.Stock_Adjustment = pStock_Adjustment;
            this.Stock_Date_Product = pStock_Date_Product;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
       
    }
}
