using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInfo.Entities;
using AspNetCoreInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreInfo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index3()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer{Id=1, FirstName="Ezgi", LastName="Dörtköşe", City="İstanbul"},
                new Customer{Id=2, FirstName="Ece",LastName="Dörtköşe", City="Ankara"},
                new Customer{Id=3, FirstName="Orkun",LastName="Dörtköşe", City="İzmir"}
            };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };

            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }
           
    }
}

