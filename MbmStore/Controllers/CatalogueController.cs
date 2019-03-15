using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        // GET: Catalogue
        public ActionResult Index()
        {

            List<Book> books = new List<Book>();
            books = Repository.Products.OfType<Book>().ToList();

            List<MusicCD> musicCD = new List<MusicCD>();
            musicCD = Repository.Products.OfType < MusicCD>().ToList();

            List<Movie> movies = new List<Movie>();
            movies = Repository.Products.OfType<Movie>().ToList();


            ViewBag.Products = Repository.Products;
            ViewBag.MusicCD = musicCD;
            ViewBag.Book = books;
            ViewBag.Movie = movies;


            return View();
        }
    }
}