namespace RepositoryLayer.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Data.Entity;
    using RepositoryLayer.Interface;
    using DataLayer.Contexts;

    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private Context dbcontext;
        private DbSet<TEntity> dbset;

        public GenericRepository(Context dbcontext)
        {
            this.dbcontext = dbcontext;
            this.dbset = dbcontext.Set<TEntity>();
        }

        /// <summary>
        /// Get all entities from db
        /// </summary>
        /// <returns></returns>

        public List<TEntity> Get()
        {
            IQueryable<TEntity> query = dbset;

            return query.ToList();

        }

         /// <summary>
        /// Get first or default entity by filter
        /// </summary>

        /// <returns></returns>

        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = dbset;

            return query.FirstOrDefault(filter);
        }

        /// <summary>
        /// Get single entity by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(object id)
        {
            return dbset.Find(id);
        }

        /// <summary>
        /// Get single entity by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public virtual void Insert(TEntity entity)
        {
            dbset.Add(entity);
        }

        /// <summary>
        /// Update entity in db
        /// </summary>
        /// <param name="entity"></param

        public virtual void Update(TEntity entity)
        {
            dbset.Attach(entity);
            dbcontext.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Delete entity from db by primary key
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(object id)
        {
            TEntity entity = dbset.Find(id);
            if (dbcontext.Entry(entity).State == EntityState.Detached)
            {
                dbset.Attach(entity);
            }
            dbset.Remove(entity);
        }
        
    }
}
