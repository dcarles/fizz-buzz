using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.MVC.Models;

namespace FizzBuzz.MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(FizzBuzzViewModel model)
        {
            return View();
        }
    }
}