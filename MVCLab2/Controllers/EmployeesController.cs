using MVCLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLab2.Controllers
{
    public class EmployeesController : Controller
    {
        ModelContext mc = new ModelContext();
        // GET: Employees
        public ViewResult Index()
        {
            return View(mc.Employees.ToList());
        }

        [HttpGet]
        public ViewResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                mc.Employees.Add(employee);
                mc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}