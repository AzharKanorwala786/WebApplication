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
            return base.GetAll();
        }

        public Product GetProduct()
        {
            return base.GetFirstOrDefault();
        }

        public Product GetByProductId(object id)
        {
            return base.GetById(id);
        }

        public IQueryable<Product> querybyProduct()
        {
            return base.Query();
        }

        public void InsertProduct(Product product)
        {
            Insert(product);
        }

        public void UpdateProduct(Product prodobj)
        {
            base.Update(prodobj);
        }

        public void DeleteProduct(int Id)
        {
            base.Delete(Id);
        }

        public void SaveChanges()
        {
            base.Save();
        }
    }
}
