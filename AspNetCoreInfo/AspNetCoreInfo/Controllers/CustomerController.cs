using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreInfo.Models;
using AspNetCoreInfo.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AspNetCoreInfo.Controllers
{
   // [Route(template: "Practice")]
    public class CustomerController : Controller
    {
        private ILogger _logger;

        public CustomerController(ILogger logger)
        {
            _logger = logger;
        }

        //[Route(template: "index")]
        public IActionResult Index()
        {
            _logger.Log("");
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1, Name="Ezgi", LastName="Dörtköşe", City="İstanbul"},
                new Customer{Id=2, Name="Ece", LastName="Dörtköşe", City="İzmir"},
                new Customer{Id=3, Name="Orkun", LastName="Dörtköşe", City="Ankara"}
            };
            List<string> shops = new List<string> { "Ankara", "İstanbul", "İzmir" };

            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel{ 
            
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text="Ankara",Value="06"},
                    new SelectListItem{Text="İstanbul",Value="34"},
                    new SelectListItem{Text="İzmir",Value="35"},

                }
            });
        }

        [HttpPost]
        public IActionResult SaveCustomer(Customer customer)
        {
            return View("Kaydedildi");
        }
    }
}
