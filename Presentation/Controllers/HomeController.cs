﻿using System;
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

            var products = 
            

            return PartialView("", productvm);
        }

    }
}