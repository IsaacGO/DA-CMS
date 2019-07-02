using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Position : BaseEntity
    {
        public int ID_Position { get; set; }
        public int ID_Area { get; set; }
        public string Name_Area { get; set; }
        public string Name_Position { get; set; }
        public Position()
        {
            ID_Position = 0;
            ID_Area = 0;
            Name_Position = "N/A";
            
        }
        public Position(int pID_Position, int pID_Area, string pName_Position)
        {
            this.ID_Position = pID_Position;
            this.ID_Area = pID_Area;
            this.Name_Position = pName_Position;
            
        }
        public Position(int pID_Position, string pName_Area, string pName_Position)
        {
            this.ID_Position = pID_Position;
            this.Name_Area = pName_Area;
            this.Name_Position = pName_Position;

        }
        public Position(int pID_Position, int pID_Area, string pName_Position,  bool pState, string pCreateBy,
        string pUpdatedBy, DateTime pCreateDate)
        {
            this.ID_Position = pID_Position;
            this.ID_Area = pID_Area;
            this.Name_Position = pName_Position;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
        }
        public Position(int pID_Position, string pName_Area, string pName_Position, bool pState, string pCreateBy,
        string pUpdatedBy, DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.ID_Position = pID_Position;
            this.Name_Area = pName_Area;
            this.Name_Position = pName_Position;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
    }
}
