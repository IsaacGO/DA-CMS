using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Customer : BaseEntity
    {
        public string ID_Customer { get; set; }
        public string Customer_name { get; set; }
        public Customer()
        {
            ID_Customer = "N/A";
            Customer_name = "N/A";
        }
        public Customer(string pID_Customer, string pCustomer_name)
        {
            this.ID_Customer = pID_Customer;
            this.Customer_name = pCustomer_name;
        }
        public Customer(string pID_Customer, string pCustomer_name, bool pState, string pCreateBy,
            string pUpdatedBy, DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.ID_Customer = pID_Customer;
            this.Customer_name = pCustomer_name;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = UpdateBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = UpdateDate;
        }
    }
}
