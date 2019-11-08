using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp126
{
    class Customer
    {
        private string name;
        private Trip trip;
        private Address adres;

        public string Name { get => name; set => name = value; }
        internal Trip Trip { get => trip; set => trip = value; }
        internal Address Adres { get => adres; set => adres = value; }

        public Customer(string name)

        {
            this.name = name;

        }

        public void SetAddress(Address adres)
        {
            this.adres = adres;
        }

        public void AssignTrip(Trip trip)
            {
            this.trip = trip;
              }


        public string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return name + " " +Trip.GetInfo() +" "+ adres.GetInfo() ;
        }


    }
}
