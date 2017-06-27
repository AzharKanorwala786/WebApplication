using System.Collections.Generic;
using System.Linq;
using BusinessLayer.Interface;
using DTO;
using RepositoryLayer.Interface;
namespace BusinessLayer.Services
{
    public class ProductService : GenericService<Product>, IProductService
    {
        private IUnitOfWork UnitofWork;
        public ProductService(IUnitOfWork UnitofWork) : base(UnitofWork)
        {
            this.UnitofWork = UnitofWork;
        }
        public IEnumerable<Product> GetAllProducts()
        { 
            return GetAll();
        }

        public Product GetProduct()
        {
            return GetFirstOrDefault();
        }

        public Product GetByProductId(object id)
        {
            return GetById(id);
        }

        public IQueryable<Product> querybyProduct()
        {
            return Query();
        }

        public void InsertProduct(Product product)
        {
            Insert(product);
        }

        public void UpdateProduct(Product prodobj)
        {
            Update(prodobj);
        }

        public void DeleteProduct(int Id)
        {
            Delete(Id);
        }

        public void SaveChanges()
        {
            Save();
        }
    }
}
