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
    public class PrepaidManagement : BaseManagement
    {
        public PrepaidManagement()
        {
            _factory = new CrudPrepaid();
        }
        private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);
        public void Create(Prepaid Obj)
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
                var ret = _factory.SuperRetrieve<Prepaid>();
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
        public List<T> SuperRetrieveById<T>(Prepaid Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Prepaid>(Obj);
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
        public List<T> SuperRetrieveByNameDescrip<T>(Prepaid Obj)
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
                var ret = _factory.RetrieveAll<Prepaid>();
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
        public List<T> RetrieveAllByNameDescrip<T>(Prepaid Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Prepaid>(Obj);
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
        public List<T> RetrieveAllById<T>(Prepaid Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Prepaid>(Obj);
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
        public List<T> RetrieveAllByIdUser<T>(Prepaid Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByIdUser<Prepaid>(Obj);
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
        public void Update(Prepaid Obj)
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
        public void Delete(Prepaid Obj)
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
        public void Activate(Prepaid Obj)
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
