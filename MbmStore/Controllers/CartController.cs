using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
using MbmStore.Infrastructure;
using MbmStore.ViewModels;

namespace MbmStore.Controllers
{
    public class CartController : Controller
    {

        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl)
        {
            Product product = Repository.Products.FirstOrDefault(p => p.ProductId ==
           productId);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { controller = returnUrl.Substring(1) });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string
       returnUrl)
        {
            Product product = Repository.Products
            .FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                cart.RemoveItem(product);
            }
            return RedirectToAction("Index", new { controller = "Cart" });
        }
        public ViewResult Index(Cart cart, string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
    }
}



