using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            IList<Login> logins = new List<Login>();
            logins.Add(new Login() { UserName = "imhemanth5@gmail.com", Password = "Hemanth@111" });
            ViewData["logins"] = logins;
            return View();
        }
    }
}
