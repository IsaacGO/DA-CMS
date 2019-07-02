using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class RoleManagement : BaseManagement
    {
        public RoleManagement()
        {
            _factory = new CrudRole();
        }
        string ExcepMessage = null; // Management Exception
        public void CreateRole(Role Obj)
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
        public List<T> SuperRetrieveRole<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.SuperRetrieve<Role>();
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
        public List<T> SuperRetrieveAllByIdRole<T>(Role Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Role>(Obj);
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
        public List<T> SuperRetrieveAllByNameRole<T>(Role Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Role>(Obj);
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
        public List<T> RetrieveAllRole<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Role>();
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
        public List<T> RetrieveAllByNameRole<T>(Role Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Role>(Obj);
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
        public List<T> RetrieveAllByIdRole<T>(Role Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Role>(Obj);
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
        public void UpdateRole(Role Obj)
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
        public void DeleteRole(Role Obj)
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
        public void ActivateRole(Role Obj)
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
