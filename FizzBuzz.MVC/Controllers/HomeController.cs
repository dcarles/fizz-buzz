using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzz.MVC.Models;
using PagedList;

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
        public ActionResult Index(FizzBuzzViewModel model, int? page)
        {
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            if (ModelState.IsValid)
            {

                var fizzBuzz = new MyFizzBuzz(() => DateTime.UtcNow);
                model.FizzBuzzNumbers = fizzBuzz.GetFizzBuzz(model.UserPosition).ToPagedList(pageNumber, pageSize);

                return RedirectToAction("FizzBuzz", new {value = model.UserPosition, page = 1});
            }
            else
                return View( model);
        }

        [HttpGet]
        public ActionResult FizzBuzz(int value, int? page)
        {
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            var model = new FizzBuzzViewModel();
            model.UserPosition = value;
            var fizzBuzz = new MyFizzBuzz(() => DateTime.UtcNow);
            model.FizzBuzzNumbers = fizzBuzz.GetFizzBuzz(model.UserPosition).ToPagedList(pageNumber, pageSize);

            return View(model);


        }
    }
}