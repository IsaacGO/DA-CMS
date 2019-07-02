using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class User : BaseEntity
    {
        public string ID_User { get; set; }
        public string User_name { get; set; }
        public string User_email { get; set; }
        public int ID_Dpt { get; set; }
        public int ID_area { get; set; }
        public int ID_position { get; set; }
        public int ID_Role { get; set; }
        public string Name_dpt { get; set; }
        public string Name_Area { get; set; }
        public string Name_Position { get; set; }
        public string Name_Role { get; set; }
        public string User_nickname { get; set; }
        public string User_pass { get; set; }
        public User()
        {
            ID_User = "N/A";
            User_name = "N/A";
            User_email = "N/A";
            ID_area = 0;
            ID_position = 0;
            ID_Role = 0;
            User_nickname = "N/A";
            User_pass = "N/A";
        }
        public User(string pID_User, string pUser_name,  
            string pUser_email, int pID_Dpt, int pID_area, int pID_position, int pID_ROLE,
            string pUser_nickname, string pUser_pass)
        {
            this.ID_User = pID_User;
            this.User_name = pUser_name;
            this.User_email = pUser_email;
            this.ID_Dpt = pID_Dpt;
            this.ID_area = pID_area;
            this.ID_position = pID_position;
            this.ID_Role = pID_ROLE;
            this.User_nickname = pUser_nickname;
            this.User_pass = pUser_pass;
        }
        public User(string pID_User, string pUser_name, 
           string pUser_email, string pName_dpt, string pName_Area, string pName_Position, string pName_Role,
           string pUser_nickname, string pUser_pass)
        {
            this.ID_User = pID_User;
            this.User_name = pUser_name;
            this.User_email = pUser_email;
            this.Name_dpt = pName_dpt;
            this.Name_Area = pName_Area;
            this.Name_Position = pName_Position;
            this.Name_Role = pName_Role;
            this.User_nickname = pUser_nickname;
            this.User_pass = pUser_pass;
        }
        public User(string pID_User, string pUser_name,  
            string pUser_email, int pID_Dpt, int pID_area, int pID_position, int pID_ROLE, int pID_address,
            string pUser_nickname, string pUser_pass, bool pState, string pCreateBy, 
            string pUpdatedBy, DateTime pCreateDate)
        {
            this.ID_User = pID_User;
            this.User_name = pUser_name;
            this.User_email = pUser_email;
            this.ID_Dpt = pID_Dpt;
            this.ID_area = pID_area;
            this.ID_position = pID_position;
            this.User_nickname = pUser_nickname;
            this.User_pass = pUser_pass;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
        }
        public User(string pID_User, string pUser_name, 
            string pUser_email, string pName_dpt, string pName_Area, string pName_Position, string pName_Role,
            string pUser_nickname, string pUser_pass, bool pState, string pCreateBy,
            string pUpdatedBy, DateTime pCreateDate, DateTime? pUpdateDate)
        {
            this.ID_User = pID_User;
            this.User_name = pUser_name;
            this.User_email = pUser_email;
            this.Name_dpt = pName_dpt;
            this.Name_Area = pName_Area;
            this.Name_Position = pName_Position;
            this.Name_Role = pName_Role;
            this.User_nickname = pUser_nickname;
            this.User_pass = pUser_pass;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdatedBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
    }
}
