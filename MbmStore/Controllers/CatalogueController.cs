using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        // GET: Catalogue
        public ActionResult Index()
        {
            Book b1 = new Book("Jungle","Jeevith", "Natteravn", 300, 2018, "junglebook.jpg", 161531861);

            ViewBag.B1 = b1;

            return View();
        }
    }
}