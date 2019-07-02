using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Permission : BaseEntity
    {
        public int ID_Per { get; set; }
        public int ID_Dpt { get; set; }
        public string Name_Dpt { get; set; }
        public string Name_Per { get; set; }
        public string Descrip_Per { get; set; }
        public Permission()
        {
            ID_Per = 0;
            ID_Dpt = 0;
            Name_Per = "N/A";
            Descrip_Per = "N/A";
        }
        public Permission(int pID_Per, int pID_Dpt, string pName_Per, string pDescrip_Per)
        {
            this.ID_Per = pID_Per;
            this.ID_Dpt = pID_Dpt;
            this.Name_Per = pName_Per;
            this.Descrip_Per = pDescrip_Per;
        }
        public Permission(int pID_Per, string pName_Dpt, string pName_Per, string pDescrip_Per)
        {
            this.ID_Per = pID_Per;
            this.Name_Dpt = pName_Dpt;
            this.Name_Per = pName_Per;
            this.Descrip_Per = pDescrip_Per;
        }
        public Permission(int pID_Per, int pID_Dpt, string pName_Per, string pDescrip_Per,bool pState, string pCreateBy,
            string pUpdatedBy, DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.ID_Per = pID_Per;
            this.ID_Dpt = pID_Dpt;
            this.Name_Per = pName_Per;
            this.Descrip_Per = pDescrip_Per;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
        public Permission(int pID_Per, string pName_Dpt, string pName_Per, string pDescrip_Per, bool? pState, string pCreateBy,
            string pUpdatedBy, DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.ID_Per = pID_Per;
            this.Name_Dpt = pName_Dpt;
            this.Name_Per = pName_Per;
            this.Descrip_Per = pDescrip_Per;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
    }
}
