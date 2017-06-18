using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;
namespace BusinessLayer
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class, IDisposable
    {
        private IUnitOfWork UnitOfWork;

        public GenericService(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }

        public IEnumerable<TEntity> GetAll()
        {       
            return UnitOfWork.Repository<TEntity>().Get();
        }

        public TEntity GetById(object Id)
        {
            return UnitOfWork.Repository<TEntity>().GetById(Id);
        }

        public IQueryable<TEntity> Query()
        {
            return UnitOfWork.Repository<TEntity>().Query();
        }

        public TEntity GetFirstOrDefault()
        {
            return UnitOfWork.Repository<TEntity>().GetFirstOrDefault();
        }

        public void Insert(TEntity entity)
        {
            UnitOfWork.Repository<TEntity>().Insert(entity);
        }

        public void Update(TEntity entityObj)
        {
            UnitOfWork.Repository<TEntity>().Update(entityObj);
        }
   
        public void Delete<T>(T Id)
        {
            UnitOfWork.Repository<TEntity>().Delete(Id);
        }
         public void Save()
        {
            UnitOfWork.Save();
        }
    }
}
