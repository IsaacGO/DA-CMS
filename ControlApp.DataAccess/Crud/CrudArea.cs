using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq; // Manipulacion de bases de datos SQL
using System.Data.Linq.Mapping; // otra clase por importar para la Manipulacion
using ControlApp.Entities.Objects;


namespace ControlApp.DataAccess.Crud
{
    public class CrudArea : CrudFactory 
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public CrudArea()
        {
            
        }
        public override bool Create(BaseEntity entity)
        {
            var ObjArea = (Area)entity;
            Context.SP_CRUD_AREA((int)CrudActionEnum.Create,ObjArea.CreateBy,ObjArea.ID_Area,ObjArea.ID_Dpt,ObjArea.Area_name);
            return true;
        }
        public override List<T> SuperRetrieve<T>()
        {
            var ObjArea = new Area();
            var lst = new List<T>();
            List<Area> MyList = new List<Area>();
            var Query = Context.SP_CRUD_AREA((int)CrudActionEnum.SuperRetrieve, ObjArea.IdSession, ObjArea.ID_Area, ObjArea.ID_Dpt, 
                ObjArea.Area_name).ToList();
            foreach (SP_CRUD_AREAResult Element in Query)
            {
                Area Obj = new Area(Element.ID_AREA,Element.NAME_DPT,Element.AREA_NAME,Element.AREA_STATE,Element.AREA_CREATEBY,
                    Element.AREA_UPDATEDBY,Element.AREA_CREATEDATE,Element.AREA_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> SuperRetrieveById<T>(BaseEntity entity)
        {
            var ObjArea = (Area)entity;
            var lst = new List<T>();
            List<Area> MyList = new List<Area>();
            var Query = Context.SP_CRUD_AREA((int)CrudActionEnum.SuperRetrieveById, ObjArea.IdSession, ObjArea.ID_Area, ObjArea.ID_Dpt, ObjArea.Area_name).ToList();
            foreach (SP_CRUD_AREAResult Element in Query)
            {
                Area Obj = new Area(Element.ID_AREA, Element.NAME_DPT, Element.AREA_NAME, Element.AREA_STATE, Element.AREA_CREATEBY,
                    Element.AREA_UPDATEDBY, Element.AREA_CREATEDATE, Element.AREA_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> SuperRetrieveByName<T>(BaseEntity entity)
        {
            var ObjArea = (Area)entity;
            var lst = new List<T>();
            List<Area> MyList = new List<Area>();
            var Query = Context.SP_CRUD_AREA((int)CrudActionEnum.SuperRetrieveByName, ObjArea.IdSession, ObjArea.ID_Area, ObjArea.ID_Dpt, ObjArea.Area_name).ToList();
            foreach (SP_CRUD_AREAResult Element in Query)
            {
                Area Obj = new Area(Element.ID_AREA, Element.NAME_DPT, Element.AREA_NAME, Element.AREA_STATE, Element.AREA_CREATEBY,
                    Element.AREA_UPDATEDBY, Element.AREA_CREATEDATE, Element.AREA_UPDATEDATE);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> RetrieveAll<T>()
       {
            var ObjArea = new Area();
            var lst = new List<T>();
            List<Area> MyList = new List<Area>();
            var Query = Context.SP_CRUD_AREA((int)CrudActionEnum.RetrieveAll, ObjArea.IdSession, ObjArea.ID_Area, ObjArea.ID_Dpt, ObjArea.Area_name).ToList();
            foreach (SP_CRUD_AREAResult Element in Query)
            {
               Area Obj = new Area(Element.ID_AREA, Element.NAME_DPT, Element.AREA_NAME);
               MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> RetrieveById<T>(BaseEntity entity)
        {
            var ObjArea = (Area)entity;
            var lst = new List<T>();
            List<Area> MyList = new List<Area>();
            var Query = Context.SP_CRUD_AREA((int)CrudActionEnum.RetrieveById, ObjArea.IdSession, ObjArea.ID_Area, ObjArea.ID_Dpt, ObjArea.Area_name).ToList();
            foreach (SP_CRUD_AREAResult Element in Query)
            {

                Area Obj = new Area(Element.ID_AREA, Element.NAME_DPT, Element.AREA_NAME);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override List<T> RetrieveByName<T>(BaseEntity entity)
        {
            var ObjArea = (Area)entity;
            var lst = new List<T>();
            List<Area> MyList = new List<Area>();
            var Query = Context.SP_CRUD_AREA((int)CrudActionEnum.RetrieveByName, ObjArea.IdSession, ObjArea.ID_Area, ObjArea.ID_Dpt, ObjArea.Area_name).ToList();
            foreach (SP_CRUD_AREAResult Element in Query)
            {
                Area Obj = new Area(Element.ID_AREA, Element.NAME_DPT, Element.AREA_NAME);
                MyList.Add(Obj);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override bool Update(BaseEntity entity)
        {
            var ObjArea = (Area)entity;
            Context.SP_CRUD_AREA((int)CrudActionEnum.Update, ObjArea.UpdateBy, ObjArea.ID_Area, ObjArea.ID_Dpt, ObjArea.Area_name);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var ObjArea = (Area)entity;
            Context.SP_CRUD_AREA((int)CrudActionEnum.Delete, ObjArea.UpdateBy, ObjArea.ID_Area, ObjArea.ID_Dpt, ObjArea.Area_name);
            return true;
        }
        public override bool Activate(BaseEntity entity)
        {
            var ObjArea = (Area)entity;
            Context.SP_CRUD_AREA((int)CrudActionEnum.Activate, ObjArea.UpdateBy, ObjArea.ID_Area, ObjArea.ID_Dpt, ObjArea.Area_name);
            return true;
        }
        public override List<T> RetrieveByIdUser<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
