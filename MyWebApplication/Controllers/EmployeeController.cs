using MyWebApplication.Models;
using MyWebApplication.viewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApplication.Controllers
{
    public class EmployeeController : Controller
    {

        Model context = new Model();
        // GET: Employee
        public ActionResult Index()
        {
            var Employees = context.Employees.ToList();
            return View(Employees);
        }

        [HttpGet ]
        public ActionResult AddEdit(int? id,Employee Employee)
        {
            if (id != null)
            {
                var x = context.Employees.Find(id);
                EmployeeViewModel EMP = new EmployeeViewModel
                {
                    Departments = context.Department.ToList(),
                    Employee = x
                };
                ViewBag.title = "Edit Emp";
                ViewBag.action = "Edit";
                return View(EMP);
            }
            else
            {
                EmployeeViewModel EM = new EmployeeViewModel
                {
                    Departments = context.Department.ToList()
                };
                ViewBag.title = "Add Emp";
                ViewBag.action = "Add";

                return View(EM);
            }
        }
        [HttpPost]
        public ActionResult AddEdit(Employee Employee)
        {
            if (Employee.id == 0)
            {
                if (ModelState.IsValid)
                {
                    context.Employees.Add(Employee);
                    context.SaveChanges();
                    ViewBag.title = "Add Employee";
                    return RedirectToAction("Index");

                }
                return View();
            }
            else
            {


                Employee empToUpdate = context.Employees.Where(p => p.id == Employee.id).FirstOrDefault();

                if (empToUpdate != null)
                {
                    context.Entry(empToUpdate).CurrentValues.SetValues(Employee);
                }
                    context.SaveChanges();

                return RedirectToAction("Index");

            }
        }
        

        public ActionResult delete(int id)
        {
            var x = context.Employees.Find(id);
            context.Employees.Remove(x);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}