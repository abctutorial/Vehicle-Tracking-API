using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Vehicle_Tracker.Models
{
    public class VehicleContext:DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options):base (options)
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleTrackingInfo> VehicleTrackingInfos { get; set; }
    }
}
