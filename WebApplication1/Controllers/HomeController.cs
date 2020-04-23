using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // return lista de usuarios
            var users = GetUsuarios();
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Valor = "Mi Valor";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Guardar(User user)
        {
            if (user == null)
            {
                ViewBag.Message = "Usuario no puede ser null";
                return View(user);
            }

            return RedirectToAction("Index");
        }

        private List<User> GetUsuarios()
        {
            return new List<User>();
        }
    }
}