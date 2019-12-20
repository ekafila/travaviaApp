using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travavia.Model
{
    public class FlyingManager
    {
        //using (ApplicationContext db = new ApplicationContext())
        //{
        //    FlightInfo flightinfo1 = new FlightInfo {FlightInfoID = 1, NumberOfTickets = 5, Price = 3000 };
        //    db.FlightInfo.Add(flightinfo1);
        //    db.SaveChanges();
        //}
        public List<Flight> Flights { get; set; }
        public List<FlightInfo> FlightInfo { get; set; }
        public FlyingManager()
        {
            Flights = GetFlights();
            FlightInfo = GetDetails();
        }
        protected List<Flight> GetFlights() 
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var flights = db.Flights.ToList();
                SortByDepartureDt(flights);
                return flights;
            }
        }
        protected List<FlightInfo> GetDetails()
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
