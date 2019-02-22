using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Product
    {
        private string title;       
        private decimal price;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string ImageUrl
        {
            get;
            set;
        }

        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price;
            }
        }

        public Product (string title, decimal price, string imageUrl)
        {
           this.Title = title;
            this.Price = price;
            this.ImageUrl = imageUrl;
       
        }


        public Product ()
        {

        }

    }
}