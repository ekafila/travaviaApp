using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travavia.Model;

namespace Travavia
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                FlightInfo flightinfo1 = new FlightInfo {FlightInfoID = 1, NumberOfTickets = 5, Price = 3000 };
                db.FlightInfo.Add(flightinfo1);
                db.SaveChanges();
            }
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
                            Console.WriteLine($"{f.FlightID}");
                            Console.ReadKey(true);
                        }
                    }

                }
            }
        }
    }
}
