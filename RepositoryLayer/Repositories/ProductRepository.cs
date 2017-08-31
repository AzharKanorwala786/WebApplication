namespace DataAccess
{
    using AutoMapper;
    using Entities;
    using System.Collections.Generic;

    public class ProductRepository : IProductRepository
    {
        private readonly IRepositoryHelper<Product> _repositoryHelper;

        private readonly IMapper _mapper;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repositoryHelper"></param>
        public ProductRepository(IRepositoryHelper<Product> repositoryHelper,IMapper mapper)
        {
            _repositoryHelper = repositoryHelper;
            _mapper = mapper;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Contracts.Product> GetAll()
        {
            var products = _repositoryHelper.Get();
            var contract = new List<Contracts.Product>();
            _mapper.Map(products,contract);       
            return contract;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="product"></param>
        public void SaveProduct(Product product)
        {
            _repositoryHelper.Insert(product);
        }
    }
}
