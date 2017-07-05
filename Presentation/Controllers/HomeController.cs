using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using DTO;
using Presentation.ViewModels;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add()
        {
            return PartialView();
        }

        public ActionResult ProductList()
        {
            ProductVM productvm = new ProductVM();

            List<ProductVM> products = new List<ProductVM>();

            products.Add(
                new ProductVM
                {
                    Name = "Amazon Echo",
                    Description = "The Echo is a Bluetooth speaker powered by Alexa",
                    Price = 350,
                    Image = "product_one.jpg",
                    Category = "Electronics",
                    CategoryId = 1
                });
            return PartialView("Products",products);
        }
    }
}