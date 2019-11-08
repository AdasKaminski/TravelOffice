using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp126
{
    class Address
    {
        private string street;
        private string zip;
        private string city;

        public string Street { get => street; set => street = value; }
        public string Zip { get => zip; set => zip = value; }
        public string City { get => city; set => city = value; }

        public Address(string street, string zip, string city)
        {
            this.street = street;
            this.zip = zip;
            this.city = city;
        }

        public string GetInfo()
        {
            return Street + " " + Zip + " " + City;
        }



    }
}
