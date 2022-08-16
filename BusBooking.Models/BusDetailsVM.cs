using BusBooking.Repositoty;
using BusBooking.Repositoty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models
{
    public class BusDetailsVM
    {
        public BusDetailsVM()
        {
            PickupStands = new HashSet<PickupStand>();
        }

        public int BusId { get; set; }
        public string BusNumber { get; set; }
        public string BusName { get; set; }
        public string BusType { get; set; }
        public int TotalSeats { get; set; }
        public int BookedSeats { get; set; }
        public bool BusDetailsStatus { get; set; }
        public int? SeatColumns { get; set; }
        public int? SeatRows { get; set; }
        public int? BusPrice { get; set; }

        public virtual ICollection<PickupStand> PickupStands { get; set; }
    }
}
