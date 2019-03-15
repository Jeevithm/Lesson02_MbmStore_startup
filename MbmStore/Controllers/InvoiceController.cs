using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private IEnumerable<Invoice> invoices;

        // GET: Invoice
        public ActionResult Index()
        {
            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();

            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.customer.firstname + " " +
                invoice.customer.lastname,
                    Value = invoice.customer.CustomerId.ToString()
                });
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z =>
            z.Text).ToList<SelectListItem>();
            ViewBag.Invoices = Repository.Invoices;
            ViewBag.CustomerId = customers;

            return View();

        }

        [HttpPost]
        public ActionResult Index(int? CustomerId)
        {

            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();

            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.customer.firstname + " " +
                invoice.customer.lastname,
                    Value = invoice.customer.CustomerId.ToString()
                });
            }
            invoices = Repository.Invoices;

            if (CustomerId != null)
            {
                // select invoices for a customer with linq
                invoices = Repository.Invoices.Where(r => r.customer.CustomerId == CustomerId);
            }
            ViewBag.Invoices = invoices;
            ViewBag.CustomerId = customers;

            return View();

        }


    }
}