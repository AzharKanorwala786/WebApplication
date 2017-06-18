using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
   public interface IGenericService<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(object id);
        IQueryable<TEntity> Query();
        TEntity GetFirstOrDefault(); 
        void Insert(TEntity entity);
        void Delete<T>(T Id);
        void Update(TEntity entityObj);
        void Save();
    }
}
