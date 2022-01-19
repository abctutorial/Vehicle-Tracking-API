using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Test_Vehicle_Tracker.Helper;
using Test_Vehicle_Tracker.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test_Vehicle_Tracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKey]
    public class TrackingController : ControllerBase
    {
        private readonly VehicleContext ctx;
        public TrackingController(VehicleContext context)
        {
            ctx = context;
        }

        [HttpPost("{vehicleid}/{lat}/{ln}")]
        public void Post(string vehicleid,string lat,string ln)
        {
            VehicleTrackingInfo vti = new VehicleTrackingInfo();
            vti.VehicleId = Convert.ToInt32(vehicleid);
            vti.Latitude = float.Parse(lat, CultureInfo.InvariantCulture.NumberFormat);
            vti.Longtitude = float.Parse(ln, CultureInfo.InvariantCulture.NumberFormat);
            ctx.VehicleTrackingInfos.Add(vti);
            ctx.SaveChanges();
        }

    }
}
