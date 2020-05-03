using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab1.Controllers
{
    public class HomeController : Controller
    {
        public class User
        {
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
        }
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult RsvForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvForm(User user)
        {
            if(user != null && user.name != null && user.email != null)
            {
                ViewBag.Name = user.name;
                return View("Welcome");
            }
            return View();
        }

    }
}