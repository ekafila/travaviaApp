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
                var users = db.Flights.ToList();
                Console.WriteLine("Проверка данных:"); //Проверяем что база данных подгружается
                foreach (Flight f in users)
                {
                    Console.WriteLine($"{f.ArrAirport}");
                    Console.ReadKey(true);
                }
            }
        }
    }
}
