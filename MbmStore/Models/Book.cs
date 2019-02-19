using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Book : Product
    {
        public string Author;
        public string Publisher;
        public short Published;
        public int ISBN;

        public Book(string title, string author, string publisher, decimal price, short published, string imageUrl, int isbn) : base(title, price, imageUrl)
        {
            this.Author = author;
            this.Publisher = publisher;
            this.Published = published;
            this.ISBN = isbn;
         
        }

        public Book ()
        {

        }
    }
}