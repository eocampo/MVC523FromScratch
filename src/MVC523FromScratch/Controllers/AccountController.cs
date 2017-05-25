using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC523FromScratch.Models;

namespace MVC523FromScratch.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Login() {

            Usuario model = new Usuario();

            model.Nombre = "José Ernesto Ocampo Cicero";
            model.Correo = "ernesto@sistrategia.com";
                        
            return View(model);
        }
    }
}