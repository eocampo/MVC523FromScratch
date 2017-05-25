using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC523FromScratch.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index() {
            return View();
        }       

        // GET: Home
        public string Menu() {
            return "Opcion 1<br>"
            + "Opcion 2<br>"
            + "Opcion 3<br>";
        }
    }
}