using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // fields
        //private string title; 
        //private decimal price; 
        //private string imageUrl { get; set; }
        private string director;
        public short Released { get; set; }


   /*     // properties
        public string Title
        {
            get { return title; } // read
        }

        public decimal Price 
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else {
                    price = value;
                }
            }
            get { return price; }
        }

*/
   /*     public string ImageUrl 
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
*/
        public string Director
        {
            get { return director; }
        }


      /*  // constructors
        public Movie(string title, decimal price)
        {
            this.title = title;
            this.price = price;
        }
        */
        public Movie(string title, decimal price, string imageUrl, string director) : base(title, price, imageUrl)
        {
          
            this.director = director;
        }

      
    }
}