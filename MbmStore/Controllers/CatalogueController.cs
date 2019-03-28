using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.ViewModels;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        // GET: Catalogue
        public int PageSize = 4;
        public ActionResult Index(string category, int page = 1)
        {
            ViewBag.Products = Repository.Products;

            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = Repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    // TotalItems = Repository.Products.Count()
                    Repository.Products.Count() :
                    Repository.Products.Where(e => e.Category == category).Count()
                },
                   CurrentCategory = category

            };

               return View(model);

        }

    }
}



