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
        public IEnumerable<Product> GetProducts()
        {
            return productService.GetAllProducts();
        }

        [HttpGet]
        public HttpResponseMessage GetCategory()
        {
            var category = categoryService.GetAllCategory().AsEnumerable();
            return ControllerContext.Request.CreateResponse(HttpStatusCode.OK, new { category });
        }

        [HttpGet]
        public IHttpActionResult Get(int Id)
        {
            var product = productService.GetByProductId(Id);
            return Ok(product);
        }

        [HttpPost]
        public IHttpActionResult Insert(Product entity)
        {
            productService.InsertProduct(entity);
            productService.SaveChanges();
            return Ok(entity);
        }
        [HttpPut]
        public IHttpActionResult Update(Product entity)
        {
            productService.UpdateProduct(entity);
            productService.SaveChanges();
            return Ok(entity);
        }
        [HttpDelete]
        public IHttpActionResult Delete(int Id)
        {
            productService.DeleteProduct(Id);
            productService.SaveChanges();
            return StatusCode(HttpStatusCode.OK);
        }
    }
}
