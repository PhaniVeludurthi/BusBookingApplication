﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusBooking.Repositoty
{
    public partial class BookingDetail
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public DateTime TravelDate { get; set; }
        public int RouteId { get; set; }
        public int SeatDetailId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public int BookingAmount { get; set; }
        public bool BookingStatus { get; set; }
        public int? SeatNumber { get; set; }
        public int? BusId { get; set; }

        public virtual Route Route { get; set; }
        public virtual SeatDetail SeatDetail { get; set; }
        public virtual SignUp User { get; set; }
    }
}
