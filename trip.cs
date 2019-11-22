using System;

namespace ConsoleApp126
{
    class Trip
    {
        private Date start;
        private Date end;
        private string destination;
        private double price;

        public string Destination { get => destination; set => destination = value; }
        internal Date Start { get => start; set => start = value; }
        internal Date End { get => end; set => end = value; }
        public double Price { get => price; set => price = value; }

        public Trip(Date start, Date end, string destination)
        {
            this.start = start;
            this.end = end;
            this.destination = destination;


        }

        public void pricetrip(double price)
        {
            this.price = price;
        }

        public string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
             return Start + " " + End + " " + Destination+" " + price;
        }
    }

}
