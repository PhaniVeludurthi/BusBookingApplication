using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models.StoredProcedureModels
{
    public  class BookingSummaryVM
    {
        [Key]
        public int BookingId { get; set; }
        public DateTime TravelDate { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public int BookingAmount { get; set; }
        public int? SeatNumber { get; set; }
        public int? BusId { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string BusNumber { get; set; }
        public string BusName { get; set; }
        public string BusType { get; set; }
    }
}
