namespace BusinessLayer.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using BusinessLayer.Interface;
    using RepositoryLayer.Interface;

    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
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
   
        public void Delete(int Id)
        {
            UnitOfWork.Repository<TEntity>().Delete(Id);
        }
         public void Save()
        {
            UnitOfWork.Save();
        }
    }
}
