using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly List<Employee> __Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Surname = "Пупкин",
                FirstName = "Иван",
                Patronymic = "Иванович",
                Age = 50
            },
            new Employee
            {
                Id = 2,
                Surname = "Александров",
                FirstName = "Пётр",
                Patronymic = "Петрович",
                Age = 25
            },
            new Employee
            {
                Id = 3,
                Surname = "Сидоров",
                FirstName = "Сидор",
                Patronymic = "Сидорович",
                Age = 30
            },
            new Employee
            {
                Id = 4,
                Surname = "Петряев",
                FirstName = "Сидор",
                Patronymic = "Олегович",
                Age = 40
            },
        };

        public IActionResult Index()
        {
            ViewBag.Title = "Hi people";

            return View(__Employees);
        }

        public IActionResult EmployeeDetails(int id)
        {
            var employee = __Employees.FirstOrDefault(e => e.Id == id);
            if (employee is null)
                return NotFound();

            return View(employee);
        }

        public IActionResult AnotherAction()
        {
            return Content("You are missing");
        }
    }
}
