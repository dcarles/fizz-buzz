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
            return View(new FizzBuzzViewModel());
        }


        [HttpPost]
        public ActionResult FizzBuzz(FizzBuzzViewModel model)
        {

            var fizzBuzz = new MyFizzBuzz();
           model.FizzBuzzNumbers = fizzBuzz.GetFizzBuzz(model.UserPosition);

            return View(model);
        }
    }
}