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
            User user = new User();
            user.Id = 1;
            user.FirstName = " Damon";
            user.LastName = "Flick ";
            user.Age = 26;
            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            throw new Exception("Invalid Page");

            return View();
        }

        public ActionResult Contact(int id = 0 )
        {
            ViewBag.Message = id;

            return View();
        }
    }
}