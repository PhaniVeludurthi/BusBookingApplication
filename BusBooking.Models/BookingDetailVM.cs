using BusBooking.Repositoty;
using BusBooking.Repositoty.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBooking.Models
{
    public class BookingDetailVM
    {
        [Key]
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
  }
}
