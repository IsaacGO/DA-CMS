using System.Collections.Generic;
using ControlApp.Entities.Objects;

namespace ControlApp.DataAccess.Crud
{
    public abstract class CrudFactory
    {
        public abstract bool Create(BaseEntity entity);
        public abstract List<T> SuperRetrieve<T>();
        public abstract List<T> SuperRetrieveById<T>(BaseEntity entity);
        public abstract List<T> SuperRetrieveByName<T>(BaseEntity entity);
        public abstract List<T> RetrieveAll<T>();
        public abstract List<T> RetrieveById<T>(BaseEntity entity);
        public abstract List<T> RetrieveByName<T>(BaseEntity entity);
        public abstract List<T> RetrieveByIdUser<T>(BaseEntity entity);
        public abstract bool Update(BaseEntity entity);
        public abstract bool Delete(BaseEntity entity);
        public abstract bool Activate(BaseEntity entity);
    }
}
