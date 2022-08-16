using System;
using System.Collections.Generic;

#nullable disable

namespace BusBooking.Repositoty.Models
{
    public partial class RouteDetail
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
