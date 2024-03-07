
using AspCoreViewImports.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreViewImports.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student{id=1,Name ="Waqar",Gender="Male"},
                new Student{id=2,Name ="Abdul",Gender="Male"},
                new Student{id=3,Name ="Tania",Gender="Female"},
                new Student{id=4,Name ="Kaveri",Gender="Female" },
                new Student{id=5,Name ="Hashim",Gender="Male" },
            };
            return View(students);
        }

        public IActionResult About()
        {
            List<Student> students = new List<Student>
            {
                new Student{id=1,Name ="Waqar",Gender="Male"},
                new Student{id=2,Name ="Abdul",Gender="Male"},
                new Student{id=3,Name ="Tania",Gender="Female"},
                new Student{id=4,Name ="Kaveri",Gender="Female" },
                new Student{id=5,Name ="Hashim",Gender="Male" },
            };
            return View(students);
        }

        public IActionResult Contact()
        {
            List<Student> students = new List<Student>
            {
                new Student{id=1,Name ="Waqar",Gender="Male"},
                new Student{id=2,Name ="Abdul",Gender="Male"},
                new Student{id=3,Name ="Tania",Gender="Female"},
                new Student{id=4,Name ="Kaveri",Gender="Female" },
                new Student{id=5,Name ="Hashim",Gender="Male" },
            };
            return View(students);
        }
    }
}
