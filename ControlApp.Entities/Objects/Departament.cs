using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Departament : BaseEntity
    {
        public int ID_Dpt { get; set; }
        public string Name_Dpt { get; set; }
        public Departament()
        {
            ID_Dpt = 0;
            Name_Dpt = "N/A";
        }
        public Departament(int pID_Dpt, string pName_Dpt)
        {
            this.ID_Dpt = pID_Dpt;
            this.Name_Dpt = pName_Dpt;
        }
        public Departament(int pID_Dpt, string pName_Dpt, bool pState, string pCreateBy,
            string pUpdatedBy, DateTime pCreateDate,DateTime? pUpdateDate)
        {
            this.ID_Dpt = pID_Dpt;
            this.Name_Dpt = pName_Dpt;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
    }
}
