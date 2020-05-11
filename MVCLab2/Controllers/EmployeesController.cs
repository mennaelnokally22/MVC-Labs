using MVCLab2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                mc.Employees.Attach(employee);
                mc.Entry(employee).State = EntityState.Modified;
                mc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Employee employee = mc.Employees.Find(id);
            if (employee != null)
            {
                mc.Employees.Remove(employee);
                mc.SaveChanges();
                return Json(true);
            }
            return HttpNotFound("Employee not found!");
        }
    }
}