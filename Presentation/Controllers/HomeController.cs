using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Contracts;
using Presentation.ViewModels;
using System.Configuration;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductVM model = new ProductVM();

            List<ProductVM> products = new List<ProductVM>()
            {
                new  ProductVM() { Name = "Amazon Echo",Description = "The Echo is a Bluetooth speaker powered by Alexa",Image = "product_one.jpg",Price = 350,CategoryId = 1,Category = "Electronics"},
                new  ProductVM() { Name = "Smart Garden Watering Notifier",Description = "Automates the Garden Water Timing without any Human Contact",Image = "Automates the Garden Water Timing without any Human Contact",Price = 250,CategoryId = 2,Category = "IOT"},
                new  ProductVM() { Name = "Selenium",Description = "Automated Testing tool",Image = "product_three.png",Price = 100,CategoryId = 3,Category = "Automation Tools"},
            };
            return View(products);
        }
        public ActionResult Add()
        {
            return PartialView();
        }
        [HttpGet]
        public ActionResult Products()
        {
            return View("Products");
        }
        public JsonResult GetAPICall()
        {
            string url = ConfigurationManager.AppSettings.Get("API");

            if (string.IsNullOrEmpty(url) == false)
            {
                return Json(url, JsonRequestBehavior.AllowGet);
            }
            return Json(url, JsonRequestBehavior.AllowGet);
        }
    }
}