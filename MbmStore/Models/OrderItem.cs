using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return TotalPrice;
            }
        }

        public OrderItem(Product product, int quantity)
        {
            this.product = product;
            this.Quantity = quantity;
        }
    }
}