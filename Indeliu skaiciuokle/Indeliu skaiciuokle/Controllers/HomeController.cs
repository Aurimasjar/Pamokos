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
        public JsonResult Skaiciuoti(Skaiciuokle skaiciuokle)
        {
            if((skaiciuokle.terminas > 0) && (skaiciuokle.terminas <= 60))
            { 
                return Json(new{rezultatas = skaiciuokle.Skaiciuoti(), rezultatas2 = "Labas"});
            }
            else
            {
                return Json(new {rezultatas2 = "Terminas turi būti tarp 0 ir 60 mėnesių" });
            }
           
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