using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication21._12._21.Controllers
{
    public class HomeController:Controller
    {
        //public ActionResult Index()
        //{
        //    var result = new ContentResult();
        //    result.Content = "homework is finished";
        //    return result;
            
        //return Content("homework is finished");

        //}


        public ViewResult Index()
        {
            ViewResult view = new ViewResult();
            view.ViewName = "index";
            return view;
        }
        public ViewResult About()
        {
            //ViewResult view = new ViewResult();
            //view.ViewName = "About";
            return View();
        }
        public ActionResult Contact()
        {
           
            return View();
        }


        public ActionResult Detail(int id)
        {
            ViewData["id"] = id;
            ViewBag.Id = id;
            //ViewBag.Id = 70;
            TempData["id"] = id;
            return View();
        }
        public JsonResult Json()
        {
            var result = new JsonResult(new { name = "Anar", surname = "Masiyev" });
            return result;

        }


    }
}
