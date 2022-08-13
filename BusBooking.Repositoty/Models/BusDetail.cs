using System;
using System.Collections.Generic;

#nullable disable

namespace BusBooking.Repositoty
{
    public partial class BusDetail
    {
        public BusDetail()
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
