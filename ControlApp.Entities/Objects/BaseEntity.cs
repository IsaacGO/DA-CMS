using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Entities.Objects
{
    public class BaseEntity
    {
        public string IdSession { get; set; }
        public bool? State { get; set; }
        public string  CreateBy { get; set; }
        public string  UpdateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
