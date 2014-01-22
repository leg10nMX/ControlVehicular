using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControlVehicular.Models
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<FuelLog> FuelLogs { get; set; }

        public DbSet<TravelLog> TravelLogs { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}