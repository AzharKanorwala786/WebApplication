namespace DataAccess
{
    using Entities;
    using System.Collections.Generic;

    public interface IProductRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<Contracts.Product> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        void SaveProduct(Product product);
    }
}
