using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travavia.Model;

namespace Travavia.Classes
{
    class Repository
    {
        public List<Flight> Flights { get; set; }
        public Repository()
        {
            // Sample data set
            Flights = new List<Flight>
            {
                new Flight
                {
                    FlightID = 1,
                    DepAirport = "Domodedovo",
                    ArrAirport = "Tegel",
                    DepartureDT = new DateTime(2019, 03, 17),
                    ArrivalDT = new DateTime(2019, 04, 17),
                    Company = "S7"
                }
            };
        }
    }
}
