using MVCLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {
                ModelContext mc = new ModelContext();
                mc.Employees.Add(employee);
                mc.SaveChanges();
                return View("Welcome",employee);
            }
            return View();
        }
    }
}