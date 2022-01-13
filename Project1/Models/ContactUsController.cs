using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            IList<ContactUs> contactUss = new List<ContactUs>();
            contactUss.Add(new ContactUs() { PhoneNumber = 630505, Email = "imhemanth5@gmail.com" });
            contactUss.Add(new ContactUs() { PhoneNumber = 020033, Email = "imhymanth@gmail.com" });
            ViewData["contactuss"] = contactUss;

            return View();
        }
    }
}
