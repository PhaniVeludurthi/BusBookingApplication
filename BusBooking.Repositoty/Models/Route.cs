using System;
using System.Collections.Generic;

#nullable disable

namespace BusBooking.Repositoty.Models
{
    public partial class Route
    {
        public Route()
        {
            PickupStands = new HashSet<PickupStand>();
            RouteDetails = new HashSet<RouteDetail>();
        }

        public int RouteId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public bool RoutesStatus { get; set; }

        public virtual ICollection<PickupStand> PickupStands { get; set; }
        public virtual ICollection<RouteDetail> RouteDetails { get; set; }
    }
}
