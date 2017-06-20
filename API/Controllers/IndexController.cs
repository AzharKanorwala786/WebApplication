using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer.Interface;
using DTO;


namespace API.Controllers
{
    public class IndexController : ApiController
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public IndexController(IProductService productService,ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return productService.GetAllProducts();
        }

        [HttpGet]
        public Product GetSingleProduct()
        {
            return productService.GetFirstOrDefault();
        }

    }
}
