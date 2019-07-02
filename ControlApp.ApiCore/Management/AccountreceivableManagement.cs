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
    public class AccountreceivableManagement : BaseManagement
    {
        public AccountreceivableManagement()
        {
            _factory = new CrudAccountreceivable();
        }
        private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);
        public void Create(Accountreceivable Obj)
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
                var ret = _factory.SuperRetrieve<Accountreceivable>();
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
        public List<T> SuperRetrieveById<T>(Accountreceivable Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Accountreceivable>(Obj);
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
        public List<T> SuperRetrieveByNameDescrip<T>(Accountreceivable Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Accountreceivable>(Obj);
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
                var ret = _factory.RetrieveAll<Accountreceivable>();
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
        public List<T> RetrieveAllByNameDescrip<T>(Accountreceivable Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Accountreceivable>(Obj);
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
        public List<T> RetrieveAllById<T>(Accountreceivable Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Accountreceivable>(Obj);
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
        public List<T> RetrieveAllByIdUser<T>(Accountreceivable Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByIdUser<Accountreceivable>(Obj);
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
        public void Update(Accountreceivable Obj)
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
        public void Delete(Accountreceivable Obj)
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
        public void Activate(Accountreceivable Obj)
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
