using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.ViewModels
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }

        public ProductVM()
        {
            //List<ProductVM> ProductList = new List<ProductVM>();

            //ProductList.Add(
            //    new ProductVM
            //    {
            //        Id = 1,
            //        Name = "Electronic Pumps",
            //        Description = "Automated Electronic Pump",
            //        Price = 2000,
            //        Image = "product_one",
            //        CategoryId = 1,
            //        Category = "Electronics"
            //    });
            // ProductList.Add(
            //     new ProductVM {
            //         Id = 1,
            //         Name = "Smart Garden Watering Notifier",
            //         Description = "Automates the Garden Water Timing without any Human Contact",
            //         Price = 2000,
            //         Image = "product_two",
            //         CategoryId = 2,
            //         Category = "IOT"
            //     });
            //ProductList.Add(
            //   new ProductVM
            //   {
            //       Id = 1,
            //       Name = "Selenium",
            //       Description = "Automated Testing tool",
            //       Price = 2000,
            //       Image = "product_three",
            //       CategoryId = 3,
            //       Category = "Automation Tools"
            //   });
        }
    }
}