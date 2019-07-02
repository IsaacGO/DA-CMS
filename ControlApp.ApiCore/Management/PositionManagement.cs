using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.DataAccess.Crud;
using ControlApp.Entities.Objects;

namespace ControlApp.ApiCore.Management
{
    public class PositionManagement : BaseManagement
    {
        public PositionManagement()
        {
            _factory = new CrudPosition();
        }
        string ExcepMessage = null; // Management Exception
        public void CreatePosition(Position Obj)
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
        public List<T> SuperRetrievePosition<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.SuperRetrieve<Position>();
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
        public List<T> SuperRetrieveAllByIdPosition<T>(Position Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveById<Position>(Obj);
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
        public List<T> SuperRetrieveAllByNamePosition<T>(Position Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.SuperRetrieveByName<Position>(Obj);
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
        public List<T> RetrieveAllPosition<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Position>();
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
        public List<T> RetrieveAllByNamePosition<T>(Position Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveByName<Position>(Obj);
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
        public List<T> RetrieveAllByIdPosition<T>(Position Obj)
        {
            var lst = new List<T>();
            try
            {
                var list = _factory.RetrieveById<Position>(Obj);
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
        public void UpdatePosition(Position Obj)
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
        public void DeletePosition(Position Obj)
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
        public void ActivatePosition(Position Obj)
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
