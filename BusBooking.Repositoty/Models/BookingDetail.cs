using System;
using System.Collections.Generic;

#nullable disable

namespace BusBooking.Repositoty.Models
{
    public partial class BookingDetail
    {
        public int BookingId { get; set; }
        public int? UserId { get; set; }
        public string TravelDate { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public int? BookingAmount { get; set; }
        public string SeatNumber { get; set; }
        public int? BusId { get; set; }
        public string SeatType { get; set; }

        public virtual BusDetail Bus { get; set; }
        public virtual SignUp User { get; set; }
    }
}
