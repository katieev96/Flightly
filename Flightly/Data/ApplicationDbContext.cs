using System;
using System.Collections.Generic;
using System.Text;
using Flightly.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Flightly.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<AircraftManufacturer> AircraftManufacturers { get; set; }
        public DbSet<AircraftModel> AircraftModels { get; set; }
        public DbSet<FlightInfo> flightInfos { get; set; }
        public DbSet<UserFlights> UserFlights { get; set; }
    }
}
