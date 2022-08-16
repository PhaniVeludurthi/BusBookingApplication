using BusBooking.Repositoty;
using BusBooking.Repositoty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models
{
    public class PickupStandVM
    {
        public PickupStandVM()
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
