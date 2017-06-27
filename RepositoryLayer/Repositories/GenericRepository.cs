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
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includes"></param>
        /// <returns></returns>

        public List<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = dbset;

            foreach(Expression<Func<TEntity,object>> include in includes)
            {
                query = query.Include(include);
            }

            if (filter != null)
                query = query.Where(filter);

            if (orderby != null)
                query = orderby(query);

            return query.ToList();

        }

        /// <summary>
        /// Get query for entity
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderby = null)
        {
            IQueryable<TEntity> query = dbset;

            if (filter != null)
                query = query.Where(filter);

            if (orderby != null)
                query = orderby(query);

            return query;
        }

        /// <summary>
        /// Get first or default entity by filter
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="includes"></param>
        /// <returns></returns>

        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter = null, params Expression<Func<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = dbset;

            foreach (Expression<Func<TEntity, object>> include in includes)
                query = query.Include(include);

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
