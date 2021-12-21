using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Narail.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Narail | 2018";
            return View();
        }
        public ActionResult Slider()
        {
            ViewBag.Title = "Narail | 2018";
            return View();
        }
        public ActionResult Info()
        {
            ViewBag.Title = "Melumat";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Title = "Haqqimizda";
            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Title = "Layiheler";
            return View();
        }
        public ActionResult Counter()
        {
            ViewBag.Title = "Counter";
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.Title = "Blog";
            return View();
        }
    }
}