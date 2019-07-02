using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;
using log4net;

namespace ControlApp.ApiCore.Management
{
    public class CustomerManagement : BaseManagement
    {
        public CustomerManagement()
        {
            _factory = new CrudCustomer();
        }
        private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);
        public void Create(Customer Obj)
        {
            try
            {
                _factory.Create(Obj);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }
        public List<T> SuperRetrieve<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.SuperRetrieve<Customer>();
                foreach (var obj in ret)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            catch (Exception ex)
            {

                log.Error(ex.Message, ex);
            }
            return lst;
        }
        public List<T> SuperRetrieveById<T>(Customer Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Customer>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return lst;
        }
        public List<T> SuperRetrieveByNameDescrip<T>(Customer Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Customer>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return lst;
        }
        public List<T> RetrieveAll<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Customer>();
                foreach (var obj in ret)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return lst;
        }
        public List<T> RetrieveAllByNameDescrip<T>(Customer Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Customer>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return lst;
        }
        public List<T> RetrieveAllById<T>(Customer Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Customer>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return lst;
        }
        public List<T> RetrieveAllByIdUser<T>(Customer Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByIdUser<Customer>(Obj);
                if (list.Count > 0)
                {
                    foreach (var obj in list)
                    {
                        lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
            return lst;
        }
        public void Update(Customer Obj)
        {
            try
            {
                _factory.Update(Obj);
            }

            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }
        public void Delete(Customer Obj)
        {
            try
            {
                _factory.Delete(Obj);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }
        public void Activate(Customer Obj)
        {
            try
            {
                _factory.Activate(Obj);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
            }
        }
    }
}