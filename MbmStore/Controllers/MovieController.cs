using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            
            // create a new Movie object with instance name jungleBook
            Movie jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "John Hitler");
            Movie lionKings = new Movie("Lion Kings", 200.40m, "lionkings.jpg", "Marc Høgh");
            Movie frozen = new Movie("Frozen", 120.50m, "frozen.jpeg", "Jeff");
            // assign a viewbag property to the new Movie object
            ViewBag.JungleBook = jungleBook;
            ViewBag.LionKings = lionKings;
            ViewBag.Frozen = frozen;
          


            return View();
        }
    }
}