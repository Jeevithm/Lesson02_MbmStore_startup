using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer customer1 = new Customer("Hans", "Jensen", "Risdalsvej 40", "8260", "Viby J");
            customer1.addPhone("26334664");
            customer1.addPhone("88445566");
            customer1.BirthDate = new DateTime(1960, 02, 02);
 
            Customer customer2 = new Customer("Astrid", "Hansen", "Bjørnevænget 2", "5500", "Middelfart");
            customer2.addPhone("21312321");
            customer2.addPhone("43534534");
            customer2.BirthDate = new DateTime(1994, 12, 27);
            Customer customer3 = new Customer("Marc", "Høgh", "Sønderhøj 30", "8260", "Viby J" );
            customer3.addPhone("78678678");
            customer3.addPhone("45645664");
            customer3.BirthDate = new DateTime(1980, 08, 02);

            ViewBag.Customer1 = customer1;
            ViewBag.Customer2 = customer2;
            ViewBag.Customer3 = customer3;

            return View();
        }
    }
}