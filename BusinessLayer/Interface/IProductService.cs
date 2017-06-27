namespace BusinessLayer.Interface
{
    using System.Collections.Generic;
    using System.Linq;
    using DTO;

    public interface IProductService : IGenericService<Product> 
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProduct();
        Product GetByProductId(object id);
        void InsertProduct(Product product);
        void UpdateProduct(Product prodobj);
        void DeleteProduct(int Id);
        void SaveChanges();
    }
}
