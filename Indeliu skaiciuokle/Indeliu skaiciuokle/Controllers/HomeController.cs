using Indeliu_skaiciuokle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Indeliu_skaiciuokle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Skaiciuokle skaiciuokle)
        {
            return View();
        }
        [HttpPost]
        public double Skaiciuoti(Skaiciuokle skaiciuokle)
        {
            
            return (skaiciuokle.Skaiciuoti());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}