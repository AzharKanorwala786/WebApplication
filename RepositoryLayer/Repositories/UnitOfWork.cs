namespace DataAccess
{
    using DataAccess;
    using Entities;
    using System;
    using System.Collections.Generic;

    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly Context dbcontext;

        private readonly IProductRepository _productRepository;

        private bool disposed = false;

        /// <summary>
        /// Intialize UnitOfWork Constructor
        /// </summary>
        /// <param name="dbcontext"></param>
        /// <param name="productRepository"></param>
        public UnitOfWork(Context dbcontext,IProductRepository productRepository)
        {
            this.dbcontext = dbcontext;
            this._productRepository = productRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Contracts.Product> GetAll()
        {
            return _productRepository.GetAll();
        }
        public void Save()
        {
            dbcontext.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbcontext.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
