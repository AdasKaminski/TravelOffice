using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp126
{
    class AbroadTrip : Trip
    {
        private double insurance;
        public AbroadTrip(Date start, Date end, string destination) : base(start, end, destination)
        {

        }

        public double Insurance { get => insurance; set => insurance = value; }

        public void setInurance(double insurance)
        {
            this.insurance = insurance;
        }
        public void getPrice()
        {
           base.Price = base.Price + insurance;
        }
    }
}
