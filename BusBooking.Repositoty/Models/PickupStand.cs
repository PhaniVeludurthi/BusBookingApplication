using System;
using System.Collections.Generic;

#nullable disable

namespace BusBooking.Repositoty.Models
{
    public partial class PickupStand
    {
        public PickupStand()
        {
            RouteDetails = new HashSet<RouteDetail>();
        }

        public int PickId { get; set; }
        public int BusId { get; set; }
        public int RouteId { get; set; }
        public bool PickupStatus { get; set; }
        public string EstimatedTime { get; set; }

        public virtual BusDetail Bus { get; set; }
        public virtual Route Route { get; set; }
        public virtual ICollection<RouteDetail> RouteDetails { get; set; }
    }
}
