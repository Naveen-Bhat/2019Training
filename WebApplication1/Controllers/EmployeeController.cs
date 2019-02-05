using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private static int idGenerator = 1;
        private static List<Employee> employees = new List<Employee>();

        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Delete(int employeeId)
        {
            var emp = employees.FirstOrDefault(x => x.Id == employeeId);

            if (emp == null)
            {
                return Content("Invalid Id");
            }

            employees.Remove(emp);

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
            var emp = employees.FirstOrDefault(x => x.Id == employeeId);

            if (emp == null)
            {
                return Content("Invalid Id");
            }

            return View(emp);
        }

        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            employee.Id = idGenerator++;
            employees.Add(employee);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            var emp = employees.FirstOrDefault(x => x.Id == employee.Id);

            if (emp == null)
            {
                return Content("Invalid Id");
            }

            emp.Name = employee.Name;
            emp.Desgination = employee.Desgination;

            return RedirectToAction("Index");
        }
    }
}