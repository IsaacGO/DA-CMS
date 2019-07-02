using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class PermissionManagament : BaseManagement
    {
        public PermissionManagament()
        {
            _factory = new CrudPermission();
        }
        string ExcepMessage = null; // Management Exception
        public void CreatedPermission(Permission Obj)
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
        public List<T> SuperRetrievedPermission<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.SuperRetrieve<Permission>();
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
        public List<T> SuperRetrieveAllByIdPermission<T>(Permission Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Permission>(Obj);
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
        public List<T> SuperRetrieveAllByNamePermission<T>(Permission Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Departament>(Obj);
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
        public List<T> RetrieveAllPermission<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Permission>();
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
        public List<T> RetrieveAllByNamePermission<T>(Permission Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Permission>(Obj);
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
        public List<T> RetrieveAllByIdPermission<T>(Permission Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Permission>(Obj);
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
        public void UpdatePermission(Permission Obj)
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
        public void DeletePermission(Permission Obj)
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
        public void ActivatePermission(Permission Obj)
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
