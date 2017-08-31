namespace BusinessLayer.Interface
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;

    public interface IProductService 
    {
        IEnumerable<Product> GetAllProducts();
        //Product GetProduct();
        //Product GetByProductId(object id);
        //void InsertProduct(Product product);
        //void UpdateProduct(Product prodobj);
        //void DeleteProduct(int Id);
        //void SaveChanges();
    }
}
