using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Accountreceivable : BaseEntity
    {
        public int Id_Cxc { get; set; }
        public string Id_Customer{ get; set; }
        public int Id_Product { get; set; }
        public int Quantity_Retreat { get; set; }
        public int Quantity_Return { get; set; }
        public decimal Total_Cxc { get; set; }
        public int Balance_Cxc { get; set; }
        /// <foreigner> variables for esthetic query of UI
        public string Name_Customer { get; set; }
        public string Name_Product { get; set; }
        /// </foreigner>
        /// Default Constructor
        public Accountreceivable()
        {
            Id_Cxc = 0;
            Id_Customer = "N/A";
            Id_Product = 0;
            Quantity_Retreat = 0;
            Quantity_Return = 0;
            Total_Cxc = 0;
            Balance_Cxc = 0;
        }
        public Accountreceivable(int pId_Cxc, string pId_Customer, int pId_Product, int pQuantity_Retreat, 
            int pQuantity_Return, decimal pTotal_Cxc, int pBalance_Cxc)
        {
            this.Id_Cxc = pId_Cxc;
            this.Id_Customer = pId_Customer;
            this.Id_Product = pId_Product;
            this.Quantity_Retreat = pQuantity_Retreat;
            this.Quantity_Return = pQuantity_Return;
            this.Total_Cxc = pTotal_Cxc;
            this.Balance_Cxc = pBalance_Cxc;
        }
        public Accountreceivable(int pId_Cxc, string pName_Customer, string pName_Product, int pQuantity_Retreat,
            int pQuantity_Return, decimal pTotal_Cxc, int pBalance_Cxc)
        {
            this.Id_Cxc = pId_Cxc;
            this.Name_Customer = pName_Customer;
            this.Name_Product = pName_Product;
            this.Quantity_Retreat = pQuantity_Retreat;
            this.Quantity_Return = pQuantity_Return;
            this.Total_Cxc = pTotal_Cxc;
            this.Balance_Cxc = pBalance_Cxc;
        }
        public Accountreceivable(int pId_Cxc, string pName_Customer, string pName_Product, int pQuantity_Retreat,
            int pQuantity_Return, decimal pTotal_Cxc, int pBalance_Cxc, bool? pState, string pCreateBy, string pUpdateBy, DateTime pCreateDate,
            DateTime? pUpdateDate)
        {
            this.Id_Cxc = pId_Cxc;
            this.Name_Customer = pName_Customer;
            this.Name_Product = pName_Product;
            this.Quantity_Retreat = pQuantity_Retreat;
            this.Quantity_Return = pQuantity_Return;
            this.Total_Cxc = pTotal_Cxc;
            this.Balance_Cxc = pBalance_Cxc;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }

    }
}
