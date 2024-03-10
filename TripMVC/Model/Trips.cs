using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.Model
{
    public class Trips
    {
        public Trips(double money, string season) 
        {
            this.Money = money;
            this.Season = season;
        }
        public double Money { get; set; }
        public string Season { get; set; }

        public double CalculateTrip()
        {
            double buget = 0;
            if (this.Money <= 100)
            {
                if (this.Season == "summer")
                {
                    buget = Money * 0.3;
                }
                else if(this.Season == "winter")
                {
                    buget = Money * 0.7;
                }
            }
            else if (this.Money <= 1000)
            {
                if (this.Season == "summer")
                {
                    buget = Money * 0.4;
                }
                else if (this.Season == "winter")
                {
                    buget = Money * 0.8;
                }
            }
            else
            {
                buget = Money * 0.9;
            }
            return buget;
        }
    }
}
