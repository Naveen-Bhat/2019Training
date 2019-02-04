using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult Marks()
        {
            var marksModel = new List<MarksModel>();

            marksModel.Add(new MarksModel()
            {
                StudentName = "Naveen",
                Mark = 50
            });

            marksModel.Add(new MarksModel()
            {
                StudentName = "Prakyath",
                Mark = 80
            });

            marksModel.Add(new MarksModel()
            {
                StudentName = "Keerthan",
                Mark = 90
            });

            return View(marksModel);
        }
    }
}