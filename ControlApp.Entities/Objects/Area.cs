using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Area : BaseEntity
    {
        public int ID_Area { get; set; }
        public int ID_Dpt { get; set; }
        public string Name_Dpt { get; set; }
        public string Area_name { get; set; }
        public Area()
        {
            ID_Area = 0;
            ID_Dpt = 0;
            Area_name = null;
        }
        public Area(int pID_Area, int pID_Dpt, string pArea_Name)
        {
            this.ID_Area = pID_Area;
            this.ID_Dpt = pID_Dpt;
            this.Area_name = pArea_Name;
        }
        public Area(int pID_Area,  string pName_Dpt ,string pArea_Name)
        {
            this.ID_Area = pID_Area;
            this.Name_Dpt = pName_Dpt;
            this.Area_name = pArea_Name;
        }
        public Area(int pID_Area, int pID_Dpt,string pArea_Name, bool? pState, string pCreateBy, string pUpdateBy, DateTime pCreateDate)
        {
            this.ID_Area = pID_Area;
            this.ID_Dpt = pID_Dpt;
            this.Area_name = pArea_Name;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
        }
        public Area(int pID_Area, string pName_Dpt, string pArea_Name, bool? pState, string pCreateBy, string pUpdateBy, DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.ID_Area = pID_Area;
            this.Name_Dpt = pName_Dpt;
            this.Area_name = pArea_Name;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
        public Area(int pID_Area, int pID_Dpt, string pIdSession, string pArea_Name, bool? pState, string pCreateBy, string pUpdateBy, DateTime pCreateDate)
        {
            this.ID_Area = pID_Area;
            this.ID_Dpt = pID_Dpt;
            this.IdSession = pIdSession;
            this.Area_name = pArea_Name;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
        }
    }
}
