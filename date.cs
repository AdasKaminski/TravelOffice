using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp126
{
    class Date
    {
        private int day;
        private int mounth;
        private int year;

        public int Day { get => day; set => day = value; }
       public int Mounth { get => mounth; set => mounth = value; }
        public int Year { get => year; set => year = value; }

        public Date(int day, int mounth, int year)
        {
            this.day = day;
            this.mounth = mounth;
            this.year = year;
        }

       
        public string GetInfo()
        {
            return ToString();
        }

        public override string ToString()
        {
            return day + " " + mounth + " " + year;
        }



    }
}
