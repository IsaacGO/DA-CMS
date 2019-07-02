using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Role : BaseEntity
    {
        public int ID_role { get; set; }
        public string Name_role { get; set; }
        public string Descrip_role { get; set; }
        public Role()
        {
            ID_role = 0;
            Name_role = "N/A";
            Descrip_role = "N/A";
        }
        public Role(int pID_role, string pName_role, string pDescrip_role)
        {
            this.ID_role = pID_role;
            this.Name_role = pName_role;
            this.Descrip_role = pDescrip_role;
        }
        public Role(int pID_role, string pName_role, string pDescrip_role, bool pState, string pCreateBy,
            string pUpdatedBy, DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.ID_role = pID_role;
            this.Name_role = pName_role;
            this.Descrip_role = pDescrip_role;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
    }
}
