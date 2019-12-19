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
        public static List<Flight> Flights { get; set; }
        public static List<FlightInfo> FlightInfo { get; set; }
        protected void GetTables() 
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var flights = db.Flights.ToList();
                var details = db.FlightInfo.ToList();
                Console.WriteLine("Проверка данных:"); //Проверяем что база данных подгружается
                foreach (Flight f in flights)
                {
                    foreach (var d in details)
                    {
                        if (f.FlightID == d.FlightInfoID)
                        {
                            Console.WriteLine($"{f.FlightID} costs {d.Price} RUB");
                            Console.ReadKey(true);
                        }
                    }
                }
            }
        }       
    }
}
