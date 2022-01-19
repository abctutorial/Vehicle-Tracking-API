using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Vehicle_Tracker.Models
{
    public class VehicleTrackingInfo
    {
        [Key]
        public int VehicleTrackingInfoId { get; set; }
        
        public int VehicleId { get; set; }
        public float Latitude { get; set; }
        public float Longtitude { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
