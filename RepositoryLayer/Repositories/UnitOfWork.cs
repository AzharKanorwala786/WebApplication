namespace RepositoryLayer.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using DataLayer.Contexts;
    using RepositoryLayer.Interface;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private Context dbcontext;
        private bool disposed = false;
        public UnitOfWork(Context dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (repositories.Keys.Contains(typeof(TEntity)) == true)
            {
                return repositories[typeof(TEntity)] as IGenericRepository<TEntity>;
            }
            IGenericRepository<TEntity> repo = new GenericRepository<TEntity>(dbcontext);
            repositories.Add(typeof(TEntity), repo);
            return repo;
        }
        public void Save()
        {
            dbcontext.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbcontext.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
