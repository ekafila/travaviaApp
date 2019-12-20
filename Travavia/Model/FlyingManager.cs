using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travavia.Model
{
    public class FlyingManager
    {
        
        public List<Flight> Flights { get; set; }
        public List<FlightInfo> FlightInfo { get; set; }

        public FlyingManager()
        {
            Flights = GetFlights();
            FlightInfo = GetDetails();
        }

        public List<Flight> GetFlights() 
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var flights = db.Flights.ToList();
                SortByDepartureDt(flights);
                return flights;
            }
        }
        public List<FlightInfo> GetDetails()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var details = db.FlightInfo.ToList();
                return details;
            }
        }
        
        protected void SortByDepartureDt(List<Flight> flightlist)
        {
            flightlist.Sort((x, y) => x.DepartureDT.CompareTo(y.DepartureDT));
        }
    }
}
