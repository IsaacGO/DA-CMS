using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Order : BaseEntity
    {
        public int Id_Order { get; set; }
        public int Id_Prepaid { get; set; }
        public int Order_Quantity { get; set; }
        public DateTime Order_Date { get; set; }
        public bool Order_Delivery { get; set; }
        /// Default Constructor
        public Order()
        {
            Id_Order = 0;
            Id_Prepaid = 0;
            Order_Quantity = 0;
            Order_Date = DateTime.Today;
            Order_Delivery = false;
        }
        /// Constructor With parameters of DB
        /// 
        public Order(int pId_Order, int pId_Prepaid, int pOrder_Quantity, DateTime pOrder_Date, bool pOrder_Delivery)
        {
            this.Id_Order = pId_Order;
            this.Id_Prepaid = pId_Prepaid;
            this.Order_Quantity = pOrder_Quantity;
            this.Order_Date = pOrder_Date;
            this.Order_Delivery = pOrder_Delivery;
        }
        public Order(int pId_Order, int pId_Prepaid, int pOrder_Quantity, DateTime pOrder_Date, bool pOrder_Delivery, bool? pState, 
            string pCreateBy, string pUpdateBy, 
            DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.Id_Order = pId_Order;
            this.Id_Prepaid = pId_Prepaid;
            this.Order_Quantity = pOrder_Quantity;
            this.Order_Date = pOrder_Date;
            this.Order_Delivery = pOrder_Delivery;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate; 
        }
    }
}
