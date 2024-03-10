using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Trip.Model;
using Trip.View;

namespace Trip.Controllers
{
    public class TripController
    {
        private Display display;
        private Trips trip;

        public TripController()
        {
            display = new Display();
            trip = new Trips(display.Money, display.Season);
            display.TotalPrice = trip.CalculateTrip();
            display.ShowPrice();
        }
    }
}
