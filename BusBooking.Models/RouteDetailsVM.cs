using BusBooking.Repositoty;
using BusBooking.Repositoty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models
{
    public class RouteDetailsVM
    {
        public int RouteDetailId { get; set; }
        public int RouteId { get; set; }
        public string ArivalTime { get; set; }
        public string DepartureTime { get; set; }
        public string RoutePoint { get; set; }
        public int Price { get; set; }
        public int PickId { get; set; }
        public bool RouteDetailsStatus { get; set; }

        public virtual PickupStand Pick { get; set; }
        public virtual Route Route { get; set; }
    }
}
