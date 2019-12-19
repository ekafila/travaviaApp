using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travavia.Model
{
    public class Flight
    {
        public int FlightID { get; set; }
        public string DepAirport { get; set; }
        public string ArrAirport { get; set; }
        public DateTime DepartureDT { get; set; }
        public DateTime ArrivalDT { get; set; }
        public string Company { get; set; }
        //public int Price { get; set; }
        //public int NumberOfTickets { get; set; }

    }
}
