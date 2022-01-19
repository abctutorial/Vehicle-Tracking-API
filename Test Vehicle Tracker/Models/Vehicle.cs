using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Vehicle_Tracker.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string VehicleName { get; set; }
        public string VehicleRegNo { get; set; }
        public string Status { get; set; }
        public ICollection<VehicleTrackingInfo> VehicleTrackingInfo { get; set; }
    }
}
