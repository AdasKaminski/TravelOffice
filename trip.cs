using System;

namespace ConsoleApp126
{
    class Trip
    {
        private Date start;
        private Date end;
        private string destination;

        public string Destination { get => destination; set => destination = value; }
        internal Date Start { get => start; set => start = value; }
        internal Date End { get => end; set => end = value; }

        public Trip(Date start, Date end, string destination)
        {
            this.start = start;
            this.end = end;
            this.destination = destination;


        }

        public string GetInfo()
        {
            return Start + " " + End + " " + Destination;
        }

    }

}
