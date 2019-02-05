using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Data;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeBusiness employeeBusiness;

        public EmployeeController()
        {
            this.employeeBusiness = new EmployeeBusiness();
        }

        public IActionResult Index()
        {
            var employees = employeeBusiness.GetEmployees();
            return View(employees);
        }

        public IActionResult Delete(int employeeId)
        {
            employeeBusiness.Delete(employeeId);
            return Json(new { redirectUrl = Url.Action("Index", "Employee") });
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Employee());
        }

        [HttpGet]
        public IActionResult Edit(int employeeId)
        {
            var emp = this.employeeBusiness.GetEmployee(employeeId);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            this.employeeBusiness.Add(employee);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            this.employeeBusiness.Update(employee);
            return RedirectToAction("Index");
        }
    }
}