using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class AreaManagement : BaseManagement
    {
       
        public AreaManagement()
        {
            _factory = new CrudArea();
            
        }
        string ExcepMessage = null; // Management Exception
        public void CreateArea(Area Obj)
        {
            try
            {
                _factory.Create(Obj);
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;
            }
        }
        public List<T> SuperRetrieveArea<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.SuperRetrieve<Area>();
                foreach (var obj in ret)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            catch (Exception ex)
            {

                ExcepMessage = "Logic Error" + ex;
            }
            return lst;
        }
        public List<T> SuperRetrieveAllByIdArea<T>(Area Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Area>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception)
            {
                //_exMan.ManageException(ex);
            }
            return lst;
        }
        public List<T> SuperRetrieveAllByNameArea<T>(Area Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Area>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception)
            {
                //_exMan.ManageException(ex);
            }
            return lst;
        }
        public List<T> RetrieveAllArea<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Area>();
                foreach (var obj in ret)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            catch (Exception ex)
            {

                ExcepMessage = "Logic Error" + ex;
            }
            return lst;
        }
        public List<T> RetrieveAllByNameArea<T>(Area Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Area>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception)
            {
                //_exMan.ManageException(ex);
            }
            return lst;
        }
        public List<T> RetrieveAllByIdArea<T>(Area Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Area>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception)
            {
                //_exMan.ManageException(ex);
            }
            return lst;
        }
        public void UpdateArea(Area Obj)
        {
            try
            {
                _factory.Update(Obj);
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;
            }
        }
        public void DeleteArea(Area Obj)
        {
            try
            {
                _factory.Delete(Obj);
            }
            catch (Exception ex)
            {
               ExcepMessage = "Logic Error" + ex;
            } 
        }
        public void ActivateArea(Area Obj)
        {
            try
            {
                _factory.Activate(Obj);
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;
            }
        }
    }
}
