﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class Note : BaseEntity
    {
        public int ID_Note { get; set; }
        public string Note_Title { get; set; }
        public DateTime Note_Date { get; set; }
        public string Note_Content { get; set; }
        public Note()
        {
            ID_Note = 0;
            Note_Title = "N/A";
            Note_Date = DateTime.Today;
            Note_Content = "N/A";
        }
        public Note(int pID_Note, string p_Note_Title, DateTime pNote_Date, string pNote_Content)
        {
            this.ID_Note = pID_Note;
            this.Note_Title = p_Note_Title;
            this.Note_Date = pNote_Date;
            this.Note_Content = pNote_Content;
        }
        public Note(int pID_Note, string p_Note_Title, DateTime pNote_Date, string pNote_Content, bool pState, string pCreateBy,
            DateTime pCreateDate, string pUpdateBy, DateTime? pUpdateDate)
        {
            this.ID_Note = pID_Note;
            this.Note_Title = p_Note_Title;
            this.Note_Date = pNote_Date;
            this.Note_Content = pNote_Content;
            this.State = pState;
            this.CreateBy = pCreateBy;
            this.UpdateBy = pUpdateBy;
            this.CreateDate = pCreateDate;
            this.UpdateDate = pUpdateDate;
        }
    }
}