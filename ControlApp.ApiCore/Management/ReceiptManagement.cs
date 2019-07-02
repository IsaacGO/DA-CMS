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
    public class ReceiptManagement : BaseManagement
    {
        
        public ReceiptManagement()
        {
            _factory = new CrudReceipt();
        }
        private static readonly ILog log = LogManager.GetLogger(System.Environment.MachineName);
        public void CreateReceipt(Receipt Obj)
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
        public List<T> SuperRetrieveReceipt<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.SuperRetrieve<Receipt>();
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
        public List<T> SuperRetrieveByIdReceipt<T>(Receipt Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Receipt>(Obj);
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
        public List<T> SuperRetrieveByNameDescripReceipt<T>(Receipt Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Receipt>(Obj);
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
        public List<T> RetrieveAllReceipt<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Receipt>();
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
        public List<T> RetrieveAllByNameDescrip<T>(Receipt Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Receipt>(Obj);
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
        public List<T> RetrieveAllByIdReceipt<T>(Receipt Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Receipt>(Obj);
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
        public List<T> RetrieveAllByIdUser<T>(Receipt Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByIdUser<Receipt>(Obj);
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
        public void UpdateReceipt(Receipt Obj)
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
        public void DeleteReceipt(Receipt Obj)
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
        public void ActivateReceipt(Receipt Obj)
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
