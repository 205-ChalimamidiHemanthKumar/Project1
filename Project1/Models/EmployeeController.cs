using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { ID = 1234, FirstName = "Hemanth", Lastname = "Kumar", Location = "Madnapalli" });
            employees.Add(new Employee() { ID = 12345, FirstName = "Rishabh", Lastname = "Panth", Location = "Delhi" });
            employees.Add(new Employee() { ID = 123456, FirstName = "Ravidhra", Lastname = "Jadeja", Location = "Chennai" });

            ViewData["emplyees"] = employees;

          

            return View();
        }
    }
}
