namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepositoryHelper<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get all entities from db
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> Get();

        /// <summary>
        /// Include Data from other tables
        /// </summary>
        /// <param name="toInclude"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetIncluding(string toInclude);

        /// <summary>
        /// Get first or default entity by filter
        /// <returns></returns>
        TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> filter = null);


        /// <summary>
        /// Get single entity by primary key
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetById(object id);


        /// <summary>
        /// Insert entity to db
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Update entity in db
        /// </summary>
        /// <param name="entity"></param
        void Update(TEntity entity);

        /// <summary>
        /// Delete entity from db by primary key
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);
    }
}
