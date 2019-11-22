using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp126
{
    class Test
    {
        static void Main(string[] args)
        {

            Customer[] klient = new Customer[2];

            klient[0] = Addcustomer();
            Console.WriteLine(klient[0].GetInfo());
        }
        static public Customer Addcustomer()
        {




            Console.WriteLine("Witaj");
            Console.WriteLine("Podaj imie");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj date rozpoczecia wycieczki");
            string start = Console.ReadLine();
            Console.WriteLine("Podaj date zakończenia wycieczki");
            string end = Console.ReadLine();
            Console.WriteLine("Podaj cel wycieczki");
            string cel = Console.ReadLine();
            Console.WriteLine("Podaj ulice");
            string ulica = Console.ReadLine();
            Console.WriteLine("Podaj numer pudynku");
            string nr = Console.ReadLine();
            Console.WriteLine("Podaj nazwe miejscowości");
            string miesto = Console.ReadLine();

            Address adress = new Address(ulica, nr, miesto);
            Customer customer = new Customer(imie);
            Date start1 = new Date(20, 4, 2015);
            Date end1 = new Date(25, 6, 2017);

            Trip trip = new Trip(start1, end1, cel);

            customer.SetAddress(adress);
            customer.AssignTrip(trip);

            return customer;


        }






    }
}
