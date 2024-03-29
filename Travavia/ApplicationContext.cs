﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travavia.Model;

namespace Travavia
{
    public class ApplicationContext : DbContext 
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightInfo> FlightInfo { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=flightsdb;Trusted_Connection=True;");
        }
    }
}
