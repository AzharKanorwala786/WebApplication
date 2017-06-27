using System.Collections.Generic;
using System.Net;
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
        public IHttpActionResult Get(int Id)
        {
            var product = productService.GetByProductId(Id);
            return Ok(product);
        }

        [HttpPost]
        public IHttpActionResult Insert(Product product)
        {
            productService.InsertProduct(product);
            productService.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }


        [HttpPut]
        public IHttpActionResult Update(Product prodobj)
        {
            productService.UpdateProduct(prodobj);
            productService.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int Id)
        {
            productService.DeleteProduct(Id);
            productService.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
