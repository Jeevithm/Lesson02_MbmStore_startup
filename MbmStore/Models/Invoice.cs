using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;
using MbmStore.Infrastructure;

namespace MbmStore.Models
{
    public class Invoice
    {
        private List<OrderItem> orderItems = new List<OrderItem>();
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer customer;

        public List<OrderItem> OrderItems
        {
            get
            {
                return orderItems;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                var price = 0M;
                foreach (var order in OrderItems)
                {
                    price += order.product.Price * order.Quantity;

                }
                return price;
            }
        }


        public List<Track> Tracks
        {
            get
            {
                return Tracks;
            }
        }
        public Invoice(int InvoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = InvoiceId;
            this.OrderDate = orderDate;
            this.customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItem o1 = new OrderItem(product, quantity);
            orderItems.Add(o1);
        }

        


    }
}