using System;
using System.Collections.Generic;

#nullable disable

namespace BusBooking.Repositoty
{
    public partial class SeatDetail
    {
        public SeatDetail()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        public int SeatDetailId { get; set; }
        public string SeatType { get; set; }
        public int SeatPrice { get; set; }
        public bool SeatDetailStatus { get; set; }

        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
