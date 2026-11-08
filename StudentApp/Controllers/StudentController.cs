using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _students = new List<Student>
        {
            new Student {Id = 1, FullName = "Kaisha Inocencio", Course = "BSCS",
            YearLevel = 3},
            new Student {Id = 2, FullName = "Hua Cheng", Course = "BSMA",
            YearLevel = 2}
        };

        public IActionResult Index()
        {
            return View(_students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            student.Id = _students.Count + 1;
            _students.Add(student);

            return RedirectToAction(nameof(Index));
        }
    }
}