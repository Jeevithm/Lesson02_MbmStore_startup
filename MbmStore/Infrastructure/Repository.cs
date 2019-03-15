using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;


namespace MbmStore.Infrastructure
{
     public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        static Repository ()
        {
            Book b1 = new Book("Jungle", "Jeevith", "Natteravn", 300, 2018, "junglebook.jpg", 161531861);

            Products.Add(b1);

            MusicCD cd1 = new MusicCD("X (Deluxe Edition)", "Svedigt Musik", 323, 2010, "edsheeran.jpg");

            Products.Add(cd1);

            Track t1 = new Track("Without me", "Eminem", new TimeSpan(0, 3, 20));
            Track t2 = new Track("Shape of you", "Ed Sheeran", new TimeSpan(0, 4, 20));

            cd1.AddTrack(t1);
            cd1.AddTrack(t2);


            Movie jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "John Hitler");
            Movie lionKings = new Movie("Lion Kings", 200.40m, "gladiator.jpg", "Marc Høgh");
            Movie frozen = new Movie("Frozen", 120.50m, "frozen.jpeg", "Jeff");

            Products.Add(jungleBook);
            Products.Add(lionKings);
            Products.Add(frozen);

            Customer customer1 = new Customer("Hans", "Jensen", "Risdalsvej 40", "8260", "Viby J");
            customer1.addPhone("26334664");
            customer1.addPhone("88445566");
            customer1.BirthDate = new DateTime(1960, 02, 02);
            customer1.CustomerId = 1;

            Customer customer2 = new Customer("Astrid", "Hansen", "Bjørnevænget 2", "5500", "Middelfart");
            customer2.addPhone("21312321");
            customer2.addPhone("43534534");
            customer2.BirthDate = new DateTime(1994, 12, 27);
            customer2.CustomerId = 2;

            Customer customer3 = new Customer("Marc", "Høgh", "Sønderhøj 30", "8260", "Viby J");
            customer3.addPhone("78678678");
            customer3.addPhone("45645664");
            customer3.BirthDate = new DateTime(1980, 08, 02);
            customer3.CustomerId = 3;


            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);


            Invoice invoice1 = new Invoice(54, new DateTime(2019, 01, 05), customer1);
            Invoice invoice2 = new Invoice(300, new DateTime(2016, 05, 20), customer2);
            Invoice invoice3 = new Invoice(69, new DateTime(1950, 02, 22), customer3);

            invoice1.AddOrderItem(jungleBook, 3);
            invoice2.AddOrderItem(cd1, 1);
            invoice3.AddOrderItem(b1, 4);

            Invoices.Add(invoice1);
            Invoices.Add(invoice2);
            Invoices.Add(invoice3);

            


        }
    }   
}