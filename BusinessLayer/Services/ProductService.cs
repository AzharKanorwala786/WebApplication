using BusinessLayer.Interface;
using Contracts;
using DataAccess;
using System.Collections.Generic;
using AutoMapper;
namespace BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _UnitofWork;

        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork UnitofWork,IMapper mapper)
        {
            this._UnitofWork = UnitofWork;
            _mapper = mapper;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            IEnumerable<Product> products = new List<Product>();
            products = _UnitofWork.GetAll();
            return products;
        }

        //public Product GetProduct()
        //{
        //    return GetFirstOrDefault();
        //}

        //public Product GetByProductId(object id)
        //{
        //    return GetById(id);
        //}
        //public void InsertProduct(Product product)
        //{
        //    Insert(product);
        //}

        //public void UpdateProduct(Product prodobj)
        //{
        //    Update(prodobj);
        //}

        //public void DeleteProduct(int Id)
        //{
        //    Delete(Id);
        //}

        //public void SaveChanges()
        //{
        //    Save();
        //}
    }
}
