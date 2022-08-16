using BusBooking.Repositoty;
using BusBooking.Repositoty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models
{
    public class SeatDetailVM
    {
        public SeatDetailVM()
        {
           /* BookingDetails = new HashSet<BookingDetail>();*/
        }

        public int SeatDetailId { get; set; }
        public string SeatType { get; set; }
        public int SeatPrice { get; set; }
        public bool SeatDetailStatus { get; set; }

       /* public virtual ICollection<BookingDetail> BookingDetails { get; set; }*/
    }
}
