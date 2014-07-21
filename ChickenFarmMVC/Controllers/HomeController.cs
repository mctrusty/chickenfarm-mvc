using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChickenFarmMVC.Models;
using System.Data.Entity;

namespace ChickenFarmMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Chicken Farm";
            FarmContext db = new FarmContext();
            var Farmers = db.Farmers.ToList();
            return View("About", Farmers);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}