using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInfo.Extensions;
using AspNetCoreInfo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreInfo.Controllers
{
    public class SessionDemoController : Controller
    {
        public IActionResult Index()
        {
            Customer customer = new Customer { Id = 1, Name = "Ezgi", LastName = "Dörtköşe", City = "İstanbul" };
            HttpContext.Session.SetObject("musteri", customer);
            return View();
        }
        public IActionResult Index2()
        {
            var customer = HttpContext.Session.GetObject<Customer>("musteri");
            return View(customer.Name);
        }
    }
}
