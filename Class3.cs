using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp126
{
    class DomesticTrip : Trip
    {
        private double ownArrivalDiscount;

        public DomesticTrip(Date start, Date end, string destination) : base(start, end, destination)
        {
        }

        public double OwnArrivalDiscount { get => ownArrivalDiscount; set => ownArrivalDiscount = value; }

       

        public void setOwnArrivalDiscount(int ownArrivalDiscount)
        {
            this.ownArrivalDiscount = ownArrivalDiscount;
        }
        public void getPrice()
        {
             base.Price=base.Price - ownArrivalDiscount;
        }

    }
}
