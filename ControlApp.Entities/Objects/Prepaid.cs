using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Prepaid : BaseEntity
    {
        public int Id_Prepaid { get; set; }
        public string Id_Customer { get; set; }
        public int Id_Product { get; set; }
        public int Prepaid_Quantity { get; set; }
        public decimal Prepaid_Total { get; set; }
        public decimal Prepaid_Cash { get; set; }
        public decimal Prepaid_Change { get; set; }
        public int Prepaid_Balance { get; set; }
        /// <foreigner> variables for esthetic query of UI
        public string Name_Product { get; set; }
        public string Name_Customer { get; set; }
        /// </foreigner>
        /// Default Constructor
        public Prepaid()
        {
            Id_Prepaid = 0;
            Id_Product = 0;
            Prepaid_Quantity = 0;
            Prepaid_Total = 0;
            Prepaid_Cash = 0;
            Prepaid_Change = 0;
            Prepaid_Balance = 0;
        }
        /// Constructor With parameters of DB
        public Prepaid(int pId_Prepaid, string pId_Customer , int pId_Product , int pPrepaid_Quantity, decimal pPrepaid_Total, 
            decimal pPrepaid_Cash, decimal pPrepaid_Change, int pPrepaid_Balance, bool? pState, string pCreateBy,  string pUpdateBy, 
            DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.Id_Prepaid = pId_Prepaid;
            this.Id_Customer = pId_Customer;
            this.Id_Product = pId_Product;
            this.Prepaid_Quantity = pPrepaid_Quantity;
            this.Prepaid_Total = pPrepaid_Total;
            this.Prepaid_Cash = pPrepaid_Cash;
            this.Prepaid_Change = pPrepaid_Change;
            this.Prepaid_Balance = pPrepaid_Balance;
        }
        public Prepaid(int pId_Prepaid, string pName_Customer, string pName_Product, int pPrepaid_Quantity, decimal pPrepaid_Total,
            decimal pPrepaid_Cash, decimal pPrepaid_Change, int pPrepaid_Balance)
        {
            this.Id_Prepaid = pId_Prepaid;
            this.Name_Customer = pName_Customer;
            this.Name_Product = pName_Product;
            this.Prepaid_Quantity = pPrepaid_Quantity;
            this.Prepaid_Total = Math.Round(pPrepaid_Total, 2);
            this.Prepaid_Cash = Math.Round(pPrepaid_Cash, 2);
            this.Prepaid_Change = Math.Round(pPrepaid_Change, 2);
            this.Prepaid_Balance = pPrepaid_Balance;
        }
        /// Constructor With parameters of DB and esthetic
        public Prepaid(int pId_Prepaid,string pName_Customer ,string pName_Product, int pPrepaid_Quantity, decimal pPrepaid_Total, 
            decimal pPrepaid_Cash, decimal pPrepaid_Change, int pPrepaid_Balance, bool? pState, string pCreateBy, string pUpdateBy,
            DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.Id_Prepaid = pId_Prepaid;
            this.Name_Customer = pName_Customer;
            this.Name_Product = pName_Product;
            this.Prepaid_Quantity = pPrepaid_Quantity;
            this.Prepaid_Total = Math.Round(pPrepaid_Total, 2);
            this.Prepaid_Cash = Math.Round(pPrepaid_Cash, 2);
            this.Prepaid_Change = Math.Round(pPrepaid_Change, 2);
            this.Prepaid_Balance = pPrepaid_Balance;
            this.State = pState;
            this.CreateBy = CreateBy;
            this.UpdateBy = UpdateBy;
            this.CreateDate = CreateDate;
            this.UpdateDate = UpdateDate;
        }
    }
}
