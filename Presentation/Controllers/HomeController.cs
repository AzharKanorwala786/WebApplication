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

        //public async Task<ActionResult> Index()
        //{   
        //}

        public ActionResult Add()
        {
            return PartialView();
        }


    }
}