using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public int age { get; set; }
        public DateTime birthDate { get; set; }
        List<string> phoneNumbers = new List<string>();

        public List<string> PhoneNumbers
        {
            get
            {
                return phoneNumbers;
            }
        }

        public int Age
        {
            get {
                DateTime now = DateTime.Now;
                int age = 0;
               
                age = now.Year - birthDate.Year;
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            }
        }
        public DateTime BirthDate
        {
            set
            {
                birthDate = value;

                if ((DateTime.Now.Year - value.Year) > 120 ||   (DateTime.Now.Year - value.Year) < 0)
                {
                    throw new Exception("Age not accepted");
                }
            }
            get
            {
                return birthDate;
            }
        }

        
        


        public Customer(string firstname, string lastname, string address, string zip, string city)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.zip = zip;
            this.city = city;
      
        }

            public void addPhone(string phone)
        {
            phoneNumbers.Add(phone);
        }
    }
}