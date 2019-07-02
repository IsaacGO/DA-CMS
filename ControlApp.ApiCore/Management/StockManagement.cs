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
    public class StockManagement : BaseManagement
    {
        public StockManagement()
        {
            _factory = new CrudStock();
        }
        private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);
        public void Create(Stock Obj)
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
                var ret = _factory.SuperRetrieve<Stock>();
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
        public List<T> SuperRetrieveById<T>(Stock Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Stock>(Obj);
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
        public List<T> SuperRetrieveByNameDescrip<T>(Stock Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Stock>(Obj);
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
                var ret = _factory.RetrieveAll<Stock>();
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
        public List<T> RetrieveAllByNameDescrip<T>(Stock Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Stock>(Obj);
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
        public List<T> RetrieveAllById<T>(Stock Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Stock>(Obj);
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
        public List<T> RetrieveAllByIdUser<T>(Stock Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByIdUser<Stock>(Obj);
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
        public void Update(Stock Obj)
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
        public void Delete(Stock Obj)
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
        public void Activate(Stock Obj)
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
