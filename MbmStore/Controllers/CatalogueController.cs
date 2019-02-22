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
            MusicCD cd1 = new MusicCD("X (Deluxe Edition)", "Svedigt Musik", 323, 2010, "edsheeran.jpg");

           Track t1 = new Track("Without me", "Eminem", new TimeSpan (0, 3, 20));
           Track t2 = new Track("Shape of you", "Ed Sheeran", new TimeSpan(0, 4, 20));
            cd1.AddTrack(t1);
           cd1.AddTrack(t2);

            ViewBag.Cd1 = cd1;
           

            return View();
        }
    }
}