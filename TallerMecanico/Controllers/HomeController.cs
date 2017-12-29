using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TallerMecanico.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Clientes()
        {
            ViewBag.Message = "Nuestros Clientes";

            return View();
        }
        public ActionResult Conocenos()
        {
            ViewBag.Message = "Ven a visitarnos";

            return View();
        }
        public ActionResult Contacto()
        {
            ViewBag.Message = "Nuestra ubicación";

            return View();
        }



    }
}
